using System;
using System.Collections.Generic;

namespace Lab4CitiesByContinentAndCountry
{
    class StratUp
    {
        static void Main(string[] args)
        {   // input                        output
            //3
            //Europe Germany Berlin      Europe:
            //Europe Bulgaria Varna         Germany -> Berlin
            //Africa Egypt Cairo            Bulgaria -> Varna
            //                           Africa:
            //                              Egypt -> Cairo

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!continents.ContainsKey(entry[0]))
                {               // 1 key                 1 value
                    continents.Add(entry[0], new Dictionary<string, List<string>>());

                }

                //              1 key               2 key
                if (!continents[entry[0]].ContainsKey(entry[1]))
                {       //      1 key           1value
                    continents[entry[0]].Add(entry[1], new List<string>());
                }

                //     1 key          2 key       2 value
                continents[entry[0]][entry[1]].Add(entry[2]);
                                
            }

            
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var item in continent.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {String.Join(", ", item.Value)}");
                }
            }

        }
    }
}
