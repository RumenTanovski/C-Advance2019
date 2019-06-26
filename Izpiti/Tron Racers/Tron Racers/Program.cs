using System;
using System.Linq;

namespace Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int fRow = 0;
            int fCol = 0;
            int sRow = 0;
            int sCol = 0;

            for (int r = 0; r < n; r++)
            {
                string line = Console.ReadLine();
                    
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[c];
                    if (matrix[r,c] == 'f')
                    {
                        fRow = r;
                        fCol = c;
                    }
                    if (matrix[r, c] == 's')
                    {
                        sRow = r;
                        sCol = c;
                    }
                }
            }


            bool firstIsLife = true;
            bool secondIsLife = true;

            while (firstIsLife && secondIsLife)
            {
                string[] com = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)                    
                    .ToArray();

                string comFirst = com[0];
                string comSecond = com[1];


                if (comFirst == "down")
                {
                    if ((fRow + 1) == n )
                    {
                        fRow = 0;
                    }
                    else fRow++;

                    if (matrix[fRow, fCol] == '*' || matrix[fRow, fCol] == 'f')
                    {
                        matrix[fRow, fCol] = 'f';
                    }
                    else
                    {
                        firstIsLife = false;
                        matrix[fRow, fCol] = 'x';
                    }

                }

                if (comFirst == "up")
                {
                    if ((fRow - 1) < 0)
                    {
                        fRow = n-1;
                    }
                    else fRow--;

                    if (matrix[fRow, fCol] == '*' || matrix[fRow, fCol] == 'f')
                    {
                        matrix[fRow, fCol] = 'f';
                    }
                    else
                    {
                        firstIsLife = false;
                        matrix[fRow, fCol] = 'x';
                    }
                }

                if (comFirst == "left")
                {
                    if ((fCol - 1) < 0)
                    {
                        fCol = n - 1;
                    }
                    else fCol--;

                    if (matrix[fRow, fCol] == '*' || matrix[fRow, fCol] == 'f')
                    {
                        matrix[fRow, fCol] = 'f';
                    }
                    else
                    {
                        firstIsLife = false;
                        matrix[fRow, fCol] = 'x';
                    }
                }

                if (comFirst == "right")
                {
                    if ((fCol + 1) > (n - 1))
                    {
                        fCol = 0;
                    }
                    else fCol++;

                    if (matrix[fRow, fCol] == '*' || matrix[fRow, fCol] == 'f')
                    {
                        matrix[fRow, fCol] = 'f';
                    }
                    else
                    {
                        firstIsLife = false;
                        matrix[fRow, fCol] = 'x';
                    }
                }

                if (firstIsLife == false)
                {
                    continue;
                }

                // second

                if (comSecond == "down")
                {
                    if ((sRow + 1) == n )
                    {
                        sRow = 0;
                    }
                    else sRow++;

                    if (matrix[sRow, sCol] == '*' || matrix[sRow, sCol] == 's')
                    {
                        matrix[sRow, sCol] = 's';
                    }
                    else
                    {
                        secondIsLife = false;
                        matrix[sRow, sCol] = 'x';
                    }
                }

                if (comSecond == "up")
                {
                    if ((sRow - 1) < 0)
                    {
                        sRow = n - 1;
                    }
                    else sRow--;

                    if (matrix[sRow, sCol] == '*' || matrix[sRow, sCol] == 's')
                    {
                        matrix[sRow, sCol] = 's';
                    }
                    else
                    {
                        secondIsLife = false;
                        matrix[sRow, sCol] = 'x';
                    }
                }

                if (comSecond == "left")
                {
                    if ((sCol - 1) < 0)
                    {
                        sCol = n - 1;
                    }
                    else sCol--;

                    if (matrix[sRow, sCol] == '*' || matrix[sRow, sCol] == 's')
                    {
                        matrix[sRow, sCol] = 's';
                    }
                    else
                    {
                        secondIsLife = false;
                        matrix[sRow, sCol] = 'x';
                    }
                }

                if (comSecond == "right")
                {
                    if ((sCol + 1) > (n - 1))
                    {
                        sCol = 0;
                    }
                    else sCol++;

                    if (matrix[sRow, sCol] == '*' || matrix[sRow, sCol] == 's')
                    {
                        matrix[sRow, sCol] = 's';
                    }
                    else
                    {
                        secondIsLife = false;
                        matrix[sRow, sCol] = 'x';
                    }
                }
            }

            //print matrix 
            for (int r = 0; r < n; r++)
            {               
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
