using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int count = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();

            string command = Console.ReadLine();
            int number = 0;
            while (command?.ToLower() != "end")
            {
                if (command?.ToLower() == "green")
                {
                    int curentCount = queue.Count > count ? count : queue.Count;
                    for (int i = 0; i < curentCount; i++)
                    {
                        builder.AppendLine($"{queue.Dequeue()} passed!");
                        number++; 
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }            
                command = Console.ReadLine();
            }
            Console.Write(builder.ToString());
            Console.WriteLine($"{number} cars passed the crossroads.");
        }
    }
}
