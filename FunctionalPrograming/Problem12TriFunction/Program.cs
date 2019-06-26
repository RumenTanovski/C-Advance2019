using System;
using System.Linq;

namespace Problem13TriFunction
{
    class Program
    {   // sumata ot `charowete da e rawna ili po-goliama

        //800                         Petromir  
        //Qvor Qnaki Petromir Sadam

        static void Main(string[] args)
        {
            var targetCharactersSum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord =
                (str, num) => str.ToCharArray()
                                 .Select(ch => (int)ch)
                                 .Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName =
                (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, targetCharactersSum, isValidWord);
            Console.WriteLine(result);
        }
    }
}
