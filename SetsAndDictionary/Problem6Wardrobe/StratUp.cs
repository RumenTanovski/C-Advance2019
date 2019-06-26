using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6Wardrobe
{
    class StratUp
    {
        static void Main(string[] args)
        {
            //   4                           Blue clothes:
            // Blue->dress,jeans,hat         * dress - 1(found!)
            // Gold->dress,t - shirt,boxers  * jeans - 1
            // White->briefs,tanktop         * hat - 1
            // Blue->gloves                  * gloves - 1
            // Blue dress                    Gold clothes:
            //                               * dress - 1
            //                               * t - shirt - 1
            //                               * boxers - 1
            //                               White clothes:
            //                               * briefs - 1
            //                               * tanktop - 1

            int line = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrop =
                new Dictionary<string, Dictionary<string, int>>();

            string[] divideBy = new string[] { " -> ", "," };

            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(divideBy, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 1; j < input.Length; j++)
                {

                    if (!wardrop.ContainsKey(input[0]))
                    {               // 1 key                 1 value
                        wardrop.Add(input[0], new Dictionary<string, int>());
                    }

                    //              1 key               2 key
                    if (!wardrop[input[0]].ContainsKey(input[j]))
                    {       //      1 key       1value
                        wardrop[input[0]].Add(input[j], 0);
                    }

                    //     1 key     2 key   2 value
                    wardrop[input[0]][input[j]]++;
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var collor in wardrop)
            {
                Console.WriteLine($"{collor.Key} clothes:");
                foreach (var dreha in collor.Value)
                {
                    if (command[0] == collor.Key && command[1] == dreha.Key)
                    {
                        Console.WriteLine($"* {dreha.Key} - {dreha.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dreha.Key} - {dreha.Value}");
                    }
                }
            }
        }
    }
}
