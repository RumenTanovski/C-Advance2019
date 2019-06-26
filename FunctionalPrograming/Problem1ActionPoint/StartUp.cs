using System;
using System.Linq;

namespace Problem1ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {       // input                output
            //Pesho Gosho Adasha      Pesho
            //                        Gosho
            //                        Adasha

            Action <string[]> printNames = names =>
                Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                .Split()
                .ToArray();
            printNames(inputNames);
        }
    }
}
