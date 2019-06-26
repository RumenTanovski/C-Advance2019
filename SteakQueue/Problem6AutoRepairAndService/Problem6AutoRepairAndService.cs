using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carModel = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queueCars = new Queue<string>(carModel);
            Stack<string> servedCars = new Stack<string>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                if (input == "Service" && queueCars.Count>0)
                {
                    string curentCar = queueCars.Dequeue();
                    servedCars.Push(curentCar);
                    Console.WriteLine($"Vehicle {curentCar} got served.");
                }
                else if (input.Contains("CarInfo"))
                {
                    string carName = input.Split('-')[1];
                    if (queueCars.Contains(carName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    { Console.WriteLine("Served."); }
                }
                else if (input =="History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }

                input = Console.ReadLine(); 
            }
            if (queueCars.Count>0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ",queueCars)}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}
