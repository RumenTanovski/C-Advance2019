using System;
using System.Collections.Generic;

namespace Problem1UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //6             Ivan           
            //Ivan          NiceGuy1234       
            //Ivan          Pesho  
            //Ivan         
            //Pesho
            //Ivan
            //NiceGuy1234

            int n = int.Parse(Console.ReadLine());

            HashSet<string> name = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();
                name.Add(currentName);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}