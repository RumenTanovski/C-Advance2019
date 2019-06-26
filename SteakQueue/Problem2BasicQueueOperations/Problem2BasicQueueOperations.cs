using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2BasicQueueOperations
{
    class Problem2BasicQueueOperations
    {
        static void Main(string[] args)
        {
            // input N S X
            int[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            // input steak
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> qNum = new Queue<int>(nums);
            // Pop S
            for (int i = 0; i < command[1]; i++)
            {
                qNum.Dequeue();
            }
            // prazen li e, sydyrga li, nai-malyk 
            if (qNum.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (qNum.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = 0;
                min = qNum.Min();
                Console.WriteLine(min);
            }
        }
    }
}
