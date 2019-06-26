using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6ReverseAndExclude
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6     5 3 1 
            //2

            //vhod poredica chisla v list i reverse
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            //vhod delitel
            var nDivisible = int.Parse(Console.ReadLine());

            // deklarirane funkciq 
            Func<int, bool> predicate = x => x % nDivisible != 0;

            //pechat na otgowariashti na uslowieto

            numbers.Where(predicate)
                .ToList()
                .ForEach(x => Console.Write($"{x} ")); ;

        }
    }
}
