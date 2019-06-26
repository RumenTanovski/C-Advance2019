using System;
using System.Linq;

namespace Problem3CustomMinFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {   //   input             output
            //1 4 3 2 1 7 13          1

            Action<int> printNumber = x => Console.WriteLine(x);
            Func<int[], int> minFunction = numbers =>
            {
                int minValue = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int minNumber = minFunction(inputNumbers);

            printNumber(minNumber);
        }
    }
}
