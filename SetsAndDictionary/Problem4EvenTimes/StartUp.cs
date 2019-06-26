using System;
using System.Collections.Generic;

namespace Problem4EvenTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {   // 80/100 ot testovete
            //3         2
            //2
            //- 1
            //2

            int line = int.Parse(Console.ReadLine());

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < line; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if (set.Contains(num))
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                {
                    set.Add(num);
                }
            }
        }
    }
}
