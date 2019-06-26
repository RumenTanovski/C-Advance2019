using System;
using System.Linq;

namespace Lab3CountUppercaseWords
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input                                               output
            // The following example shows how to use Function     The
            //                                                     Function 
            
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => Char.IsUpper(w[0]))
                .Select(w =>
                {
                    Console.WriteLine(w);
                    return w;
                })
                .Count();
                //.ToList();


        }
    }
}
