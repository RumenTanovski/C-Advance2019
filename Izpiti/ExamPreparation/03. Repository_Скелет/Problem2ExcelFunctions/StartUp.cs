using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2ExcelFunctions
{
    class StartUp
    {
        // 70/100
        static int r;
        static int c;
        static string[][] jaged;

        static void Main(string[] args)
        {
            r = int.Parse(Console.ReadLine());

            string[] header = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            jaged = new string[r - 1][];


            for (int row = 0; row < r - 1; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                c = line.Length;
                jaged[row] = line;
            }

            string[] com = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int colHeader = 0;
            if (com[0] == "hide")
            {
                for (int i = 0; i < c; i++)
                {
                    if (header[i] == com[1])
                    {
                        colHeader = i;
                    }
                }

                List<string> listHeader = new List<string>(header);
                listHeader.RemoveAt(colHeader);
                Console.WriteLine(string.Join(" | ", listHeader));

                for (int row = 0; row < r-1; row++)
                {
                    List<string> list = new List<string>(jaged[row]);                        
                    list.RemoveAt(colHeader);
                    Console.WriteLine(string.Join(" | ", list));
                }

            }


            if (com[0] == "sort")
            {
                for (int i = 0; i < c; i++)
                {
                    if (header[i] == com[1])
                    {
                        colHeader = i;
                    }
                }

                Console.WriteLine(string.Join(" | ", header));
                jaged = jaged.OrderBy(inner => inner[colHeader]).ToArray();

                for (int i = 0; i < r - 1; i++)
                {
                    Console.WriteLine(String.Join(" | ", jaged[i]));
                }
            }

            // filter firstName Marry
            if (com[0] == "filter")
            {
                for (int i = 0; i < c; i++)
                {
                    if (header[i] == com[1])
                    {
                        colHeader = i;
                    }
                }

                for (int i = 0; i < r - 1; i++)
                {
                    if (jaged[i][colHeader] == com[2])
                    {
                        Console.WriteLine(string.Join(" | ", header));
                        Console.WriteLine(String.Join(" | ", jaged[i]));
                    }
                }

            }
        }
    }      
}
