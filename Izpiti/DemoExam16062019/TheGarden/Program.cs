using System;
using System.Linq;

namespace TheGarden
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numLine = int.Parse(Console.ReadLine());

            char[][] jaged = new char[numLine][];

            for (int i = 0; i < numLine; i++)
            {
                char[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                jaged[i] = input;
            }

            //
            int harmed = 0;
            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;

            string line =string.Empty;

            while ((line = Console.ReadLine())!= "End of Harvest")
            {
                string[] com = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = com[0];
                int mRow = int.Parse(com[1]);
                int mCol = int.Parse(com[2]);

                if (command == "Harvest"&& IsInside(jaged, mRow, mCol))
                {
                    char position = jaged[mRow][mCol];
                    if (position != ' ')
                    {
                        if (position == 'C')
                        {
                            carrots++;
                        }
                        else if (position == 'P')
                        {
                            potatoes++;
                        }
                        else
                        {
                            lettuce++;
                        }
                        jaged[mRow][mCol] = ' ';
                    }
                }
                else if (command == "Mole" && IsInside(jaged, mRow, mCol))
                {
                    string direction = com[3].ToLower();

                    if (direction == "up")
                    {
                        for (int i = mRow; i >= 0; i-=2)
                        {
                            if (IsInside(jaged, i, mCol))
                            {
                                if (IsInside(jaged, i, mCol))
                                {
                                    if (jaged[i][mCol] != ' ')
                                    {
                                        harmed++;
                                        jaged[i][mCol] = ' ';
                                    }
                                }
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = mRow; i < numLine; i+=2)
                        {
                            if (IsInside(jaged, i, mCol))
                            {
                                if (jaged[i][mCol] != ' ')
                                {
                                    harmed++;
                                    jaged[i][mCol] = ' ';
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {

                        for (int i = mCol; i >= 0; i-=2)
                        {
                            if (IsInside(jaged, mRow, i))
                            {
                                if (jaged[mRow][i] != ' ')
                                {
                                    harmed++;
                                    jaged[mRow][i] = ' ';
                                }
                            }
                        }
                    }
                    else if(direction == "right")
                    {
                        for (int i = mCol; i < jaged[mCol].Length; i+=2)
                        {
                            if (IsInside(jaged, mRow, i))
                            {
                                if (jaged[mRow][i] != ' ')
                                {
                                    harmed++;
                                    jaged[mRow][i] = ' ';
                                }
                            }
                        }
                    }
                }
                
            }


            for (int i = 0; i < numLine; i++)
            {
                Console.WriteLine($"{string.Join(" ", jaged[i])}");
            }

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");

            Console.WriteLine($"Harmed vegetables: {harmed}");

        }

        private static bool IsInside(char[][] jaged, int row, int col)
        {
            return row >= 0 && row < jaged.Length && col >= 0 && col < jaged[row].Length; ;
        }
    }
}
