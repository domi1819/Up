﻿using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using domi1819.UpCore.Utilities;

namespace domi1819.UpCore.Config
{
    public class Config
    {
        public string ServerAddress { get; set; }
        
        public int ServerPort { get; set; }
        
        public string UserId { get; set; }
        
        public string Password { get; set; }
        
        public bool LocalScreenshotCopy { get; set; }

        public DropArea DropArea { get; set; }

        public UpdateBehavior UpdateBehavior { get; set; }
        
        public string KeyFile { get; set; }
        
        public bool PngScreenshots { get; set; }
        
        public bool PendingUpdate { get; set; }

        public Hotkeys Hotkeys { get; set; }

        public WrappedColor ThemeColor { get; set; }
        
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(Config));

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(Constants.Client.ConfigFileName))
            {
                Serializer.Serialize(writer, this);
            }
        }

        public static Config Load()
        {
            Config settings;

            if (File.Exists(Constants.Client.ConfigFileName))
            {
                using (StreamReader reader = new StreamReader(Constants.Client.ConfigFileName))
                {
                    settings = (Config)Serializer.Deserialize(reader);
                }
            }
            else
            {
                settings = new Config { ServerAddress = "up.domi1819.xyz", ServerPort = 1819, UserId = "username", Password = "password", LocalScreenshotCopy = true, DropArea = new DropArea(), KeyFile = "public.key", PngScreenshots = true, Hotkeys = new Hotkeys(), ThemeColor = WrappedColor.Of(Color.FromArgb(16, 48, 128)) };
            }

            return settings;
        }
    }
}
