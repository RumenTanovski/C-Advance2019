using System;
using System.Collections.Generic;

namespace Lab3ProductShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            //lidl, juice, 2.30
            //fantastico, apple, 1.20
            //kaufland, banana, 1.10
            //fantastico, grape, 2.20
            //Revision

            string[] entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (entry[0] != "Revision")
            {
                if (!shops.ContainsKey(entry[0]))
                {
                    shops.Add(entry[0], new Dictionary<string, double>());
                }

                if (!shops[entry[0]].ContainsKey(entry[1]))
                {
                    shops[entry[0]].Add(entry[1], 0);
                }
                
                //     1 key      2 key                  value
                shops[entry[0]][entry[1]] = Double.Parse(entry[2]);

                entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            // fantastico->
            // Product: apple, Price: 1.2
            // Product: grape, Price: 2.2  ...
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}-> ");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
