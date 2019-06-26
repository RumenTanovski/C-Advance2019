using System;
using System.Collections.Generic;
using System.Linq;

namespace P8BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfPareneses = new Stack<char>();
            char[] input = Console.ReadLine()
                .ToCharArray();
            char[] openParenetses = new char[] { '(', '{', '[' };

            bool isValid = true;

            foreach (var item in input)
            {
                if (openParenetses.Contains(item))
                {
                    stackOfPareneses.Push(item);
                    continue;
                }

                if (stackOfPareneses.Count ==0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfPareneses.Peek() == '(' && item==')')
                {
                    stackOfPareneses.Pop();
                }
                else if (stackOfPareneses.Peek() == '[' && item == ']')
                {
                    stackOfPareneses.Pop();
                }
                else if (stackOfPareneses.Peek() == '{' && item == '}')
                {
                    stackOfPareneses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
