using System;
using System.Collections.Generic;
using System.Linq;

namespace SocksNew
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] lineLeft = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            int[] lineRight = Console.ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            Stack<int> left = new Stack<int>(lineLeft);
            Queue<int> right = new Queue<int>(lineRight);

            Queue<int> result = new Queue<int>();
            int maxSum = 0;
            
            while (left.Count > 0 && right.Count > 0)
            {
                int lS = left.Peek();
                int rS = right.Peek();

                if (lS>rS)
                {
                    int sumCurent = lS + rS;
                    if (maxSum<sumCurent)
                    {
                        maxSum = sumCurent;
                    }
                        result.Enqueue(sumCurent);
                    left.Pop();
                    right.Dequeue();
                }

                if (lS < rS)
                {
                    left.Pop();                    
                }
                if (lS==rS)
                {
                    right.Dequeue();
                    left.Pop();
                    lS++;
                    left.Push(lS);
                }
                              
            }

            Console.WriteLine(maxSum);
            Console.WriteLine(string.Join(" ",result));                        
        }
    }
}
