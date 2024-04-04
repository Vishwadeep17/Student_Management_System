using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Services.Services
{
    internal class FileService
    {
        public static string UploadFile(string fileName, byte[] fileData)
        {
            string mediaFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "media");

            if (!Directory.Exists(mediaFolderPath))
            {
                Directory.CreateDirectory(mediaFolderPath);
            }

            string filePath = Path.Combine(mediaFolderPath, fileName);
            File.WriteAllBytes(filePath, fileData);

            return filePath;
        }

        public static byte[] GetFile(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "media", fileName);

            if (File.Exists(filePath))
            {
                byte[] fileData = File.ReadAllBytes(filePath);
                return fileData;
            }
            else
            {
                return null;
            }
        }
    }
}
