using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MultipartUploadTestTools_Core.Common
{
    public static class FileHelper
    {
        public async static Task<Model.FileInfo> GetFileInfoAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                return GetFileInfo(filePath);
            });
        }

        public static Model.FileInfo GetFileInfo(string filePath)
        {
            try
            {

                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    var fileInfo = new Model.FileInfo
                    {
                        Path = stream.Name,
                        Name = Path.GetFileName(stream.Name),
                        Length = stream.Length,
                        LengthKB = stream.Length / 1024,
                        LengthMB = stream.Length / 1024 / 1024
                    };

                    var startTime = DateTime.Now;
                    using (var md5Provider = new MD5CryptoServiceProvider())
                    {
                        var btFileMD5 = md5Provider.ComputeHash(stream);
                        var sbFileMD5 = new StringBuilder();
                        for (int i = 0; i < btFileMD5.Length; i++)
                        {
                            sbFileMD5.Append(btFileMD5[i].ToString("X2"));
                        }
                        fileInfo.MD5 = sbFileMD5.ToString();
                    }
                    fileInfo.MD5ComputingTime = (DateTime.Now - startTime).TotalMilliseconds;

                    return fileInfo;
                }

            }
            catch (Exception ex)
            {
                return new Model.FileInfo { Exception = ex };
            }
        }
    }
}
