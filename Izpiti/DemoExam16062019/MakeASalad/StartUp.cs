using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> veg = new Queue<string>(line1);

            int[] line2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> salad = new Stack<int>(line2);

            Queue<int> redySalad = new Queue<int>();


            int numIteracSalad = salad.Count();

            for (int i = 0; i < numIteracSalad; i++)
            {
                int currentSalad = salad.Peek();

                int numIteraciVeg = veg.Count;
                for (int j = 0; j < numIteraciVeg; j++)
                {
                    int numVeg = 0;
                    string currentVeg = veg.Dequeue();
                    string enqueVeg = currentVeg;
                    if (currentVeg == "tomato")
                    {
                        numVeg = 80;
                    }
                    else if (currentVeg == "carrot")
                    {
                        numVeg = 136;
                    }
                    else if (currentVeg == "lettuce")
                    {
                        numVeg = 109;
                    }
                    else if (currentVeg == "potato")
                    {
                        numVeg = 215;
                    }

                    currentSalad = currentSalad - numVeg;

                    if (currentSalad <= 0)
                    {
                        int tempSalad = salad.Pop();
                        redySalad.Enqueue(tempSalad);
                        break;
                    }
                }

                if (veg.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"{string.Join(" ", redySalad)}");
            if (salad.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", salad)}");
            }

            if (veg.Count() > 0)
            {
                veg.Reverse();
                Console.WriteLine($"{string.Join(" ", veg)}");
            }


        }
    }
}
