using System;

namespace MultipartUploadTestTools_Core.Model
{
    public class FileInfo
    {
        public string Path { get; set; }

        public string Name { get; set; }

        public long Length { get; set; }

        public long LengthKB { get; set; }

        public long LengthMB { get; set; }

        public string MD5 { get; set; }

        public double MD5ComputingTime { get; set; }

        public Exception Exception { get; set; }
    }
}
