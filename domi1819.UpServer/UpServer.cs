﻿using System;
using System.IO;
using System.Reflection;
using domi1819.UpCore.Crypto;
using domi1819.UpCore.Network;
using domi1819.UpCore.Utilities;
using domi1819.UpServer.Console;
using domi1819.UpServer.Server;

namespace domi1819.UpServer
{
    internal class UpServer
    {
        internal static UpServer Instance { get; private set; }

        internal ServerConfig Config { get; private set; }

        internal UserManager Users { get; private set; }

        internal FileManager Files { get; private set; }
        
        internal UpConsole Console { get; } = new UpConsole();

        private NetServer messageServer;

        internal UpServer()
        {
            Instance = this;
        }

        internal void RunServer()
        {
            this.Console.WriteLine("================================");
            this.Console.WriteLine($"UpServer {Assembly.GetExecutingAssembly().GetName().Version}");
            this.Console.WriteLine("https://up.domi1819.xyz");
            this.Console.WriteLine("================================\n");

            this.Config = ServerConfig.Load(Constants.Server.ConfigFileName);
            this.Config.Save(Constants.Server.ConfigFileName);
            
            Directory.CreateDirectory(this.Config.DataFolder);
            Directory.CreateDirectory(this.Config.FileStorageFolder);
            Directory.CreateDirectory(this.Config.FileTransferFolder);

            string publicKeyPath = Path.Combine(this.Config.DataFolder, Constants.Encryption.PublicKeyFile);
            string privateKeyPath = Path.Combine(this.Config.DataFolder, Constants.Encryption.PrivateKeyFile);

            if (!File.Exists(privateKeyPath))
            {
                this.Console.WriteLine($"Generating a RSA-{Constants.Encryption.RsaKeySize} key. This might take a few seconds... ");

                Rsa.GenerateKeyPair(privateKeyPath, publicKeyPath, Constants.Encryption.RsaKeySize);

                this.Console.WriteLine("Done.");
            }

            this.Console.WriteLine("Starting UpServer...");
            
            RsaKey rsaKey = RsaKey.FromFile(privateKeyPath);
            
            if (rsaKey.Csp.KeySize != Constants.Encryption.RsaKeySize)
            {
                this.Console.WriteLine($"Unsupported key size {rsaKey.Csp.KeySize}. Expected: {Constants.Encryption.RsaKeySize}");
                return;
            }

            this.Users = new UserManager(this);
            this.Files = new FileManager(this);

            this.messageServer = new NetServer(this);
            this.messageServer.Start(this.Config.UpServerPort, rsaKey);

            this.Console.WriteLine($"Message server listening on port {this.Config.UpServerPort}.");

            this.Console.WriteLine("UpServer started.");
            
            UpWebService webService = new UpWebService(this);
            webService.Start();
            
            this.Console.ProcessConsoleInput();

            this.Console.WriteLine("Stopping UpServer...");

            webService.Stop();
            this.messageServer.Stop();
            this.Users.Shutdown();
            this.Files.Shutdown();

            Environment.Exit(0);
        }
    }
}
