using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {   // input N S X
            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            // input steak
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNum = new Stack<int>(nums);
            // Pop S
            for (int i = 0; i < command[1]; i++)
            {
                stackNum.Pop();
            }
            // prazen li e, sydyrga li, nai-malyk 
            if (stackNum.Count == 0)
            {
                Console.WriteLine("0");
            }
            else  if (stackNum.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else 
            {
                int min = 0;
                min = stackNum.Min();
                Console.WriteLine(min);
            }
        }
    }
}
