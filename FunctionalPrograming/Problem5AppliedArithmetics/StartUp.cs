using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5AppliedArithmetics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5      3 4 5 6 7
            //add
            //print
            //add
            //end

            List<int> numbersInt = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbersInt = numbersInt.Select(n => n + 1).ToList(); ;
                        break;

                    case "multiply":
                        numbersInt = numbersInt.Select(n => n * 2).ToList();
                        break;

                    case "subtract":
                        numbersInt = numbersInt.Select(n => n - 1).ToList();
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ",numbersInt));
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
