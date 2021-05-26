using Humanizer.Bytes;
using System;
using System.IO;

namespace POC.FileSizeCount
{
    static class Program
    {
        static void Main(string[] args)
        {
            long size = 0;
            DirectoryInfo dir = new DirectoryInfo(@"\.folder");
            foreach (FileInfo fi in dir.GetFiles("*.*", SearchOption.AllDirectories)) size += fi.Length;
            

            var maxFileSize = ByteSize.FromBytes(size);            
            Console.WriteLine($"maxFileSize.Bytes: {maxFileSize.Bytes:#.##}");
            Console.WriteLine($"maxFileSize.Kilobytes: {maxFileSize.Kilobytes:#.##}");
            Console.WriteLine($"maxFileSize.Megabytes: {maxFileSize.Megabytes:#.##}");
            Console.WriteLine($"maxFileSize.Gigabytes: {maxFileSize.Gigabytes:#.##}");
        }
    }
}
