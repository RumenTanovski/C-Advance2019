using System;
using System.Collections.Generic;
using System.Linq;

namespace P4FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foods = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> order = new Queue<int>(input);
            Console.WriteLine(order.Max());

            int sum = 0;
            while (order.Count>0)
            {
                if (sum<foods && (sum+order.Peek())<foods)
                {
                    sum += order.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (order.Count>0)
            {
                Console.Write("Orders left: ");
                Console.Write(String.Join(" ",order)); 
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
