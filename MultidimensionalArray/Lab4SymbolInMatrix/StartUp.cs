using System;
using System.Linq;

namespace Lab4SymbolInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[3, 3];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] item = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = item[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool noSymbol = true;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        noSymbol = false;
                        break;
                    }
                }
                    if (noSymbol == false)
                    {
                    break;
                    }
            }

            if (noSymbol)
            {
                Console.WriteLine($"{(char)symbol} does not occur in the matrix ");
            }
        }
    }
}
