using System;
using System.Linq;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort Even Numbers       output
            // 4, 2, 1, 3, 5            4, 2    
            Console.WriteLine(String.Join(", ", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)));

        }
    }
}
