using System;
using System.Collections.Generic;

namespace Problem5CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //    input              output
            // SoftUni rocks     : 1 time / s
            //                  S: 1 time / s
            //                  U: 1 time / s
            //                  c: 1 time / s
            //                  f: 1 time / s
            //                  i: 1 time / s

            string input = Console.ReadLine();
            SortedSet<char> symbols = new SortedSet<char>(input);
            
            int count = 0;
            foreach (var item in symbols)
            {
                count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (item == input[i])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{item}: {count} time/s");
            }            
        }
    }
}
