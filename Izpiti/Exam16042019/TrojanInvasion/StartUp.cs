using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // 70/100
            int waves = int.Parse(Console.ReadLine());

            int[] inputPlate = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> plate = new Queue<int>(inputPlate);
            Stack<int> warior = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {

                warior = new Stack<int>
                         (
                         Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray()
                         );

                if (i % 3 == 0)
                {
                    int plateBonus = int.Parse(Console.ReadLine());
                    plate.Enqueue(plateBonus);
                }


                while (warior.Count != 0 && plate.Count != 0)
                {

                    int cuurentPlate = plate.Dequeue();
                    int cuurentWarrior = warior.Pop();

                    if (cuurentPlate > cuurentWarrior)
                    {
                        cuurentPlate -= cuurentWarrior;
                        plate.Enqueue(cuurentPlate);
                    }
                    else
                    if (cuurentPlate < cuurentWarrior)
                    {
                        cuurentWarrior -= cuurentPlate;
                        warior.Push(cuurentWarrior);
                    }
                    else
                    if (cuurentPlate == cuurentWarrior)
                    {
                        cuurentPlate = 0;
                    }
                }
                if (plate.Count == 0)
                {
                    break;
                }
            }

            if (plate.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            }
            if (warior.Count != 0)
            {
                Console.WriteLine($"Warriors left: {string.Join(", ", warior)}");
            }
            if (plate.Count != 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plate)}");
            }

        }
    }
}

