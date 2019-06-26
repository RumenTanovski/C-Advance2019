using System;
using System.IO;
using System.Text;

namespace Lab2SliceFile4Parts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string path = "files";
            string fileName = "input.txt";
            //string outputFile = "output.txt";
            string filePath = Path.Combine(path, fileName);

            using (var inputFile = new FileStream(filePath,FileMode.Open))
            {
                long size = inputFile.Length;
                int partSize = (int)Math.Ceiling((double)size / 4);

                byte[] buffer = new byte[partSize];

                for (int i = 0; i < 4; i++)
                {
                    using (var outputFile = new FileStream($"files\\part-{1}.txt", FileMode.CreateNew)
                    {
                        int readedBytes = inputFile.Read(buffer, 0, partSize);

                        outputFile.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}
