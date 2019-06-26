using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3PeriodicTable
{
    class StartUp
    {
        static void Main(string[] args)
        {   //  input           output
            //3               Ch Ge Mo Nb Ne O Tc
            //Ge Ch O Ne
            //Nb Mo Tc
            //O Ne
            int line = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }

            SortedSet<string> sortElements = new SortedSet<string>(elements);
            Console.WriteLine(String.Join(" ", sortElements));
        }
    }
}
