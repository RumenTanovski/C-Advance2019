using System;
using System.Linq;

namespace Problem2_2x2_SquaresInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int nRow = dim[0];
            int nCol = dim[1];            

           // read matrix
            char[][] matrix = new char[nRow][];

            for (int i = 0; i < nRow; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            // prowerka za kwadrati w matrix
            int count = 0;

            for (int i = 0; i < nRow - 1; i++)
            {
                for (int j = 0; j < nCol - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] 
                        && matrix[i][j] == matrix[i + 1][j] 
                        && matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
