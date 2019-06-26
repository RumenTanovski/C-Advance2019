using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberEngine = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberEngine; i++)
            {
                string[] dataEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = dataEngine[0];
                int power = int.Parse(dataEngine[1]);
                int displacement = 0;
                string efficiency = "n/a";

                if (dataEngine.Length == 4)
                {
                    displacement = int.Parse(dataEngine[2]);
                    efficiency = dataEngine[3];
                }
                else
                {

                    if (dataEngine.Length == 3)
                    {
                        string three = dataEngine[2];
                        if (three.All(char.IsDigit))
                        {
                            displacement = int.Parse(three);
                        }
                        else
                        {
                            efficiency = three;
                        }
                    }
                }

                Engine currentEngine = new Engine(model, power, displacement, efficiency);
                engines.Add(currentEngine);
            }

            int numCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] dataCar = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                string modelCar = dataCar[0];
                string engineModel = "";
                int enginePower = 0;
                int engineDisplacement = 0;
                string engineEfficiency = "";
                foreach (var item in engines)
                {
                    if (item.Model == dataCar[1])
                    {
                        engineModel = item.Model;
                        enginePower = item.Power;
                        engineDisplacement = item.Displacement;
                        engineEfficiency = item.Efficiency;
                    }
                }

                Engine engineCurrent = new Engine(engineModel, enginePower,
                    engineDisplacement, engineEfficiency);

                int weight = 0;
                string color = "n/a";

                if (dataCar.Length == 4)
                {
                    weight = int.Parse(dataCar[2]);
                    color = dataCar[3];
                }
                else
                {
                    if (dataCar.Length == 3)
                    {
                        string three = dataCar[2];
                        if (three.All(char.IsDigit))
                        {
                            weight = int.Parse(three);
                        }
                        else
                        {
                            color = three;
                        }
                    }
                }

                Car currentCar = new Car(modelCar, engineCurrent, weight, color);
                cars.Add(currentCar);
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");
                Console.WriteLine($"    Power: {item.Engine.Power}");
                if (item.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {item.Engine.Displacement}");
                }
                
                Console.WriteLine($"    Efficiency: {item.Engine.Efficiency}");

                if (item.Weight ==0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                Console.WriteLine($"  Weight: {item.Weight}");
                }
                Console.WriteLine($"  Color: {item.Color}");
            }
        }
    }
}
