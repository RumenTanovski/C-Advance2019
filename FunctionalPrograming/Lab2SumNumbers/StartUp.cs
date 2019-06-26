using System;
using System.Linq;

namespace Lab2SumNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input            
            //2, 4, 6
            
            // output
            //3 (count)
            //12(sum)

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());

        }
        public static Func<string, int> Parse = n => Int32.Parse(n); 
    }
}
