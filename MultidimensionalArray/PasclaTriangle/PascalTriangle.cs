﻿using System;

namespace PasclaTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[size][];
            int cols = 1 ;
            for (int i = 0; i < size; i++)
            {
                jaggedArray[i] = new long[cols];
                jaggedArray[i][0] = 1;
                jaggedArray[i][cols-1] = 1;

                if (cols>2)
                {
                    long[] previosRow = jaggedArray[i - 1];
                    for (int j = 1; j < cols-1; j++)
                    {
                        jaggedArray[i][j] = previosRow[j] + previosRow[j - 1];
                    }
                }
                cols++;
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ",item));
            }

        }
    }
}
