﻿using System.IO;

namespace domi1819.UpServer.Server.Messages
{
    internal class FinishUpload : IMessage
    {
        private readonly FileManager files;
        private readonly UserManager users;
        private readonly ServerConfig config;

        public FinishUpload(FileManager files, UserManager users, ServerConfig config)
        {
            this.files = files;
            this.users = users;
            this.config = config;
        }

        public void OnMessage(MessageContext context, Connection connection)
        {
            UploadUnit unit = connection.UploadUnit;

            if (connection.UserId != null && unit != null)
            {
                unit.FileStream.Close();
                unit.FileStream.Dispose();

                string fileId = this.files.GetNewFileId();
                this.files.AddFile(fileId, unit.FileName, connection.UserId, unit.Size);

                File.Move(unit.TempFile, Path.Combine(this.config.FileStorageFolder, fileId));
                this.users.RemoveTransferStorage(connection.UserId, unit.Size);
                this.files.SetDownloadable(fileId, true);

                context.WriteNextString(string.Format(this.files.GetLinkFormat(), fileId));

                connection.UploadUnit = null;
            }
            else
            {
                context.Disconnect = true;
            }
        }
    }
}