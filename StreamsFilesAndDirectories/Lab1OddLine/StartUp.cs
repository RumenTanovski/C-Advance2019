using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Lab1OddLine
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Odd Lines
            // string filePath = "files" + Path.PathSeparator + "input.txt";
            // syzdawa se papka files w proekta s fail input.txt
            string path = "files";
            string fileName = "input.txt";
            string outputFile = "output.txt";
            string filePath = Path.Combine(path, fileName);

            using (var reader = new StreamReader(filePath))
            {
                int count = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter(Path.Combine(path, outputFile)))
                {
                    while (line != null)
                    {
                        if (count % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
