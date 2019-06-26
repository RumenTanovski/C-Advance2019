using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //4                             Geo
            //Kurnelia Qnaki Geo Muk Ivan   Muk
            //                              Ivan

            Action<List<string>, int> printByLenth = (namesA, lenthA) =>namesA
            .Where(w => w.Count() <= lenthA)
            .Select(s =>
            {
                Console.WriteLine(s);
                return s;
            })
            .Count();
                        
            int lenth = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            printByLenth(names, lenth);

        }
    }
}
