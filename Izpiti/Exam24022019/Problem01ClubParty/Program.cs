using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string[] line2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<string> input = new Stack<string>(line2);
            bool isOpen = false;
            bool isFul = true;
            Queue<char> qHalls = new Queue<char>();

          while (true)
          {
              string vre = input.Pop();
                char[] charArr = vre.ToCharArray();
                char symbol = charArr[0];

                if (vre.Count() == 1 && !Char.IsDigit(symbol))
                {
                    qHalls.Enqueue(symbol);
                }

              if (true)
              {
          
              }
          
          }

        }
    }
}
