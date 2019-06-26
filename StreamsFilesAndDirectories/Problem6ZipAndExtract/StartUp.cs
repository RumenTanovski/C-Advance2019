using System;
using System.IO;
using System.IO.Compression;

namespace Problem6ZipAndExtract
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\..\..\myNewzip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }

        }
    }
}
