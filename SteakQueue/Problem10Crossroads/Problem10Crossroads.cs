using System;
using System.Collections.Generic;

namespace Problem10Crossroads
{
    class Problem10Crossroads
    {
        static void Main(string[] args)
        {
            Queue<string> qOfCars = new Queue<string>();
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            bool isHitted = false;
            string hitCar = string.Empty;
            char hitSymbol = '\0';
            int totalCars = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    qOfCars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }

                int currentGreen = greenLight;
                while (currentGreen > 0 && qOfCars.Count>0)
                {
                    string carName = qOfCars.Dequeue();
                    int carLength = carName.Length;

                    if(currentGreen-carLength >= 0)
                    {
                        currentGreen -= carLength;
                        totalCars++;
                    }
                    else
                    {
                        currentGreen += freeWindow;

                        if (currentGreen-carLength >=0)
                        {
                            totalCars++;
                            break;
                        }
                        else
                        {
                            isHitted = true;
                            hitCar = carName;
                            hitSymbol = carName[currentGreen];
                            break;
                        }
                    }
                }

                if (isHitted)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hitCar} was hit at {hitSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
