using System;
using System.Linq;

namespace Lab4AddVAT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //  input           output
            //1, 3, 5, 7        1.20
            //                  3.60
            //                  6.00    
            //                  8.40

            double[] prices =Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();
            foreach (var item in prices)
            {
                Console.WriteLine(item.ToString("n2"));
            }
        }
    }
}
