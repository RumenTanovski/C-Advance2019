using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Supermarket
{
    class Lab6Supermarket
    {
        static void Main(string[] args)
        {// ne dobre
            Stack<string> klienti = new Stack<string>();
            string input = Console.ReadLine();
            Stack<string> platili = new Stack<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    platili.Push(klienti.Pop());
                }
                else
                {
                    klienti.Push(input);
                }
                input = Console.ReadLine();
            }
            
            if (platili.Count > 0)
            {
                for (int i = 0; i < platili.Count; i++)
                {
                    Console.WriteLine(platili.Pop());
                }
            }

            if (klienti.Count > 0)
            {
                Console.WriteLine($"{klienti.Count} people remaining.");
            }
        }
    }
}
