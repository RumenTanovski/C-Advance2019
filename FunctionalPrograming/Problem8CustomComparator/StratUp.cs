using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8CustomComparator
{
    class StratUp
    {
        static void Main(string[] args)
        {

            Action<List<int>> printEven = nums => nums
            .Where(w => w % 2 == 0)
            .OrderBy(o => o)
            .Select(s =>
            {
                Console.Write(s + " ");
                return s;
            })
            .Count();

            Action<List<int>> printOdd = nums => nums
            .Where(w => w % 2 != 0)
            .OrderBy(o => o)
            .Select(s =>
            {
                Console.Write(s + " ");
                return s;
            })
            .Count();


            var series = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            printEven(series);
            printOdd(series);
        }
    }
}