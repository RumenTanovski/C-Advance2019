using System;
using System.Collections.Generic;

namespace Lab7SoftUniParty
{
    class StartUp
    {
        static void Main(string[] args)
        {   // input        otput
            //7IK9Yo0h      7IK9Yo0h
            //9NoBUajQ      tSzE5t0p
            //Ce8vwPmE
            //SVQXQCbc
            //tSzE5t0p
            //PARTY
            //9NoBUajQ
            //Ce8vwPmE
            //SVQXQCbc
            //END

            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            var entry = Console.ReadLine();
            
            while(entry?.ToLower() != "party")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Add(entry);
                }
                else
                {
                    guests.Add(entry);
                }
                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry?.ToLower()!="end")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Remove(entry);
                }
                else
                {
                    guests.Remove(entry);
                }
                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count +vips.Count);

            foreach (var guest in vips)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
