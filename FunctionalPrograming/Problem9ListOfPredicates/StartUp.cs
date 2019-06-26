using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem9ListOfPredicates
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input numbers
            var max = int.Parse(Console.ReadLine());

            // list popylvane
            List<int> list = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                list.Add(i);
            }

            // input deliteli
            var dividers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // prewyrtame gi prez delitelite
            for (int i = dividers.Count - 1; i >= 0; i--)
            {
                list = list.Where(x => x % dividers[i] == 0)
                    .ToList();
            }

            //pechat
            Console.WriteLine(string.Join(" ", list));
            
        }
    }
}
