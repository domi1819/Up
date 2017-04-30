﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using domi1819.UpClient.Forms;
using domi1819.UpCore.Config;
using domi1819.UpCore.Network;
using domi1819.UpCore.Utilities;

namespace domi1819.UpClient.Uploads
{
    internal class UploadManager
    {
        private readonly Config config;
        private readonly NetClient netClient;

        private readonly UploadQueueForm queueForm;

        private readonly List<UploadItem> uploadItems = new List<UploadItem>();

        internal UploadManager(UpClient upClient)
        {
            this.config = upClient.Config;
            this.netClient = upClient.NetClient;

            this.queueForm = new UploadQueueForm(upClient);

            this.queueForm.BackgroundWorker.DoWork += this.StartUpload;
            this.queueForm.BackgroundWorker.RunWorkerCompleted += this.UploadCompleted;

        }

        internal void AddItem(UploadItem item)
        {
            lock (this.uploadItems)
            {
                this.uploadItems.Add(item);
            }

            this.Refresh();
        }

        internal void AddItems(IEnumerable<string> paths)
        {
            lock (this.uploadItems)
            {
                foreach (string path in paths)
                {
                    this.uploadItems.Add(new UploadItem { FolderPath = Path.GetDirectoryName(path), FileName = Path.GetFileNameWithoutExtension(path), FileExtension = Path.GetExtension(path) });
                }
            }

            this.Refresh();
        }

        private void Refresh()
        {
            this.queueForm.FitSize(this.queueForm.RefreshList(this.uploadItems));

            if (!this.queueForm.BackgroundWorker.IsBusy)
            {
                this.queueForm.KeepVisible = true;
                this.queueForm.BackgroundWorker.RunWorkerAsync();
            }

            this.queueForm.Show();
        }

        private void StartUpload(object sender, DoWorkEventArgs args)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            try
            {
                if (!this.netClient.ClaimConnectHandle())
                {
                    args.Result = new UploadResult { Title = "Connection failed!", Message = "Key is not trusted or has changed." };
                    return;
                }
            }
            catch (SocketException ex)
            {
                List<UploadItem> cleanupItems;

                lock (this.uploadItems)
                {
                    cleanupItems = this.uploadItems.Where(item => item.TemporaryFile).ToList();
                    this.uploadItems.Clear();
                }

                foreach (UploadItem item in cleanupItems)
                {
                    CleanupTempFile(item.FolderPath, item.FileName, item.FileExtension, this.config.LocalScreenshotCopy);
                }

                args.Result = new UploadResult { Title = "Connection failed!", Message = ex.Message };
                return;
            }

            if (this.netClient.Login(this.config.UserId, this.config.Password))
            {
                args.Result = this.Upload(worker, this.netClient);
            }
            else
            {
                args.Result = new UploadResult { Title = "Login failed!", Message = "Please check your account settings." };
            }

            this.netClient.ReleaseConnectHandle();
        }

        private UploadResult Upload(BackgroundWorker worker, NetClient client)
        {
            byte[] fileBuf = new byte[4096];
            UploadResult result = new UploadResult();

            while (this.uploadItems.Count > 0)
            {
                UploadItem item;

                lock (this.uploadItems)
                {
                    item = this.uploadItems[0];
                }

                string file = Path.Combine(item.FolderPath, $"{item.FileName}{item.FileExtension}");

                if (File.Exists(file))
                {
                    string transferKey = client.InitiateUpload(Path.GetFileName(file), new FileInfo(file).Length);

                    if (!string.IsNullOrEmpty(transferKey))
                    {
                        using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            int currentRead;
                            long totalRead = 0;

                            Stopwatch stopwatch = Stopwatch.StartNew();
                            int lastUpdate = 0;

                            worker.ReportProgress(0, 0L);

                            while ((currentRead = stream.Read(fileBuf, 0, (int)Math.Min(fileBuf.Length, stream.Length - totalRead))) > 0)
                            {
                                client.UploadPacket(transferKey, fileBuf, 0, currentRead);

                                totalRead += currentRead;

                                if (stopwatch.ElapsedMilliseconds / 100 >= lastUpdate)
                                {
                                    lastUpdate = (int)(stopwatch.ElapsedMilliseconds / 100);

                                    worker.ReportProgress((int)(100 * totalRead / stream.Length), (long?)(1000 * totalRead / (stopwatch.ElapsedMilliseconds + 1)));
                                }
                            }
                        }

                        worker.ReportProgress(100, 0L);

                        string link = client.FinishUpload(transferKey);

                        result.FileLinks.Add(link);
                        result.SucceededFiles++;
                    }
                    else
                    {
                        result.FailedFiles++;
                    }

                    this.queueForm.Invoke(new Action(this.Refresh));
                }
                else
                {
                    result.FailedFiles++;
                }

                if (item.TemporaryFile) // Screenshot or clipboard dump
                {
                    CleanupTempFile(item.FolderPath, item.FileName, item.FileExtension, this.config.LocalScreenshotCopy);
                }

                lock (this.uploadItems)
                {
                    this.uploadItems.RemoveAt(0);
                }

                worker.ReportProgress(100, 0L);
            }

            return result;
        }

        private void UploadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UploadResult result = (UploadResult)e.Result;

            this.queueForm.Hide();

            if (result.SucceededFiles + result.FailedFiles == 0)
            {
                InfoForm.Show(result.Title, result.Message, 5000);
            }

            if (result.SucceededFiles == 1 && result.FailedFiles == 0)
            {
                Clipboard.SetText(result.FileLinks[0]);
                InfoForm.Show("Upload completed!", "A link to your file has been copied to your clipboard.", 3000);
            }
            else if (result.SucceededFiles > 2 && result.FailedFiles == 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, result.FileLinks));
                InfoForm.Show("Upload completed!", "A list of download links has been copied to your clipboard.", 3000);
            }
            else
            {
                InfoForm.Show("Upload completed with errors!", "Some files were uploaded, some failed. Links to successfully uploaded files are in your Clipboard. Check the log for details.", 5000);
            }
        }

        internal static void CleanupTempFile(string folderPath, string fileName, string fileExtension, bool copyLocal, bool showInExplorer = false)
        {
            if (copyLocal || showInExplorer)
            {
                if (!Directory.Exists(Constants.Client.LocalItemsFolder))
                {
                    Directory.CreateDirectory(Constants.Client.LocalItemsFolder);
                }

                string sourcePath = Path.Combine(folderPath, $"{fileName}{fileExtension}");
                string destinationPath = Path.Combine(Constants.Client.LocalItemsFolder, $"{fileName}{fileExtension}");
                int tries = 0;

                while (File.Exists(destinationPath))
                {
                    tries++;
                    destinationPath = Path.Combine(Constants.Client.LocalItemsFolder, $"{fileName}_{tries}{fileExtension}");
                }

                File.Move(sourcePath, destinationPath);

                if (showInExplorer)
                {
                    Process.Start("explorer", $"/select, \"{destinationPath}\"");
                }
            }

            Directory.Delete(folderPath, true);
        }
    }
}
