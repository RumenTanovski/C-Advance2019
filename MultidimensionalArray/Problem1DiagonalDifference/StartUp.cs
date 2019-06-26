using System;
using System.Linq;

namespace Problem1DiagonalDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] item = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = item[col];
                }
            }

            int primDiag = 0;
            for (int row = 0; row < n; row++)
            {
                primDiag += matrix[row, row];
            }
            

            int secDiag = 0;
            for (int row = 0; row < n; row++)
            {
                int col = n - 1 - row;
                    secDiag += matrix[row, col];                
            }
            
            int differance = Math.Abs(primDiag - secDiag);
            Console.WriteLine(differance);

        }
    }
}
