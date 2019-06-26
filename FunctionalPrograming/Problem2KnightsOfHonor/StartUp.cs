using System;
using System.Linq;

namespace Problem2KnightsOfHonor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input                    output
            //Pesho Gosho Adasha      Sir Pesho
            //                        Sir Gosho
            //                        Sir Adasha

            Action<string[]> printNames = names =>
               Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split()
                .ToArray();

            printNames(inputNames);
        }
    }
}
