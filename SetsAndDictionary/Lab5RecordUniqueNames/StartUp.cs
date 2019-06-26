using System;
using System.Collections.Generic;

namespace Lab5RecordUniqueNames
{
    class StartUp
    {
        static void Main(string[] args)
        {   //input     output
            //6         Roki
            //Roki            
            //Roki           

            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                var entry = Console.ReadLine();
                names.Add(entry);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
