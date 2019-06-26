using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 2     1
            //1       
            //3
            //1
            //5

            int[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < num[0]; i++)
            {
                int current = int.Parse(Console.ReadLine());
                set1.Add(current);
            }

            for (int i = 0; i < num[1]; i++)
            {
                int current = int.Parse(Console.ReadLine());
                set2.Add(current);
            }

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    Console.Write(item+" ");
                }
            }
        }
    }
}

