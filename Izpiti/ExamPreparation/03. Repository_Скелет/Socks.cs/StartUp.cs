using System;

namespace Socks
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] lineLeft = int.Parse(Console.ReadLine())
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();



        }
    }
}
