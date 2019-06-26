using System;
using System.Collections.Generic;

namespace Lab6ParkingLot
{
    class StratUp
    {
        static void Main(string[] args)
        {
            //  input                   output
            //IN, CA2844AA        Parking Lot is Empty
            //IN, CA1234TA
            //OUT, CA2844AA
            //OUT, CA1234TA
            //END

            HashSet<string> carPlates = new HashSet<string>();
            var entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (entry[0]?.ToLower() != "end")
            {
                switch (entry[0]?.ToLower())
                {
                    case "in":
                        carPlates.Add(entry[1]);
                        break;

                    case "out":
                        carPlates.Remove(entry[1]);
                        break;
                    default:
                        break;
                }
                entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carPlates.Count>0)
            {
                foreach (var plate in carPlates)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
