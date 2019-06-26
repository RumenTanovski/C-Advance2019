using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3MaximumAndMinimumElement
{
    class Problem3MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stackNum = new Stack<int>();
            Queue<int> queueMaxMin = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                switch (command[0])
                {
                    case 1:
                        stackNum.Push(command[1]);
                        break;
                    case 2:
                        if (stackNum.Count > 0)
                        {
                            stackNum.Pop();
                        }
                        break;
                    case 3:
                        queueMaxMin.Enqueue(stackNum.Max());
                        break;
                    case 4:
                        queueMaxMin.Enqueue(stackNum.Min());
                        break;
                    default:
                        break;
                }               
            }
            for (int i = 0; i < queueMaxMin.Count; i++)
            {
                Console.WriteLine(queueMaxMin.Dequeue());
            }

            Console.WriteLine(String.Join(", ", stackNum));
        }
    }
}
