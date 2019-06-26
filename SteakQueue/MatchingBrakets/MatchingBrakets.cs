using System;
using System.Collections.Generic;

namespace MatchingBrakets
{
    class MatchingBrakets
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expr[i] == ')')
                {
                    int startIndex = stack.Pop();
                    Console.WriteLine(expr.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
