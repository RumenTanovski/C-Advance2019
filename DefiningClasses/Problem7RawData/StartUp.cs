using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            // tqlo
            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                // "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} 
                //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} 
                //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string model = line[0];
                Engine engine = new Engine(int.Parse(line[1]),int.Parse(line[2]));
                Cargo cargo = new Cargo(int.Parse(line[3]), line[4]);
                Tire tire1 = new Tire(double.Parse(line[5]), int.Parse(line[6]));
                Tire tire2 = new Tire(double.Parse(line[7]), int.Parse(line[8]));
                Tire tire3 = new Tire(double.Parse(line[9]), int.Parse(line[10]));
                Tire tire4 = new Tire(double.Parse(line[11]), int.Parse(line[12]));
                Tire[] tires = {tire1,tire2,tire3,tire4}; 
                
                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }
           
            // input comand

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    
                    if (car.Tires[0].TirePressure<1 || car.Tires[1].TirePressure < 1 
                        || car.Tires[2].TirePressure < 1 || car.Tires[3].TirePressure < 1)
                    { 
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType =="flamable" && car.Engine.EnginePower>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

        }
    }
}
