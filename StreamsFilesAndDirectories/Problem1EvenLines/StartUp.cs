using System;
using System.IO;
using System.Linq;

namespace Problem1EvenLines
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string textFilePath = @"text.txt";
            //string textFilePath = @"..\..\text.txt";

            int counter = 0;

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine !=null)
                {
                    if (counter%2 ==0)
                    {
                    string replacedSymbols = ReplaceSpecilaCharacters(currentLine);
                    string reversedWords = RevercedWords(replacedSymbols);

                    Console.WriteLine(reversedWords);
                    }
                    currentLine = streamReader.ReadLine();
                    counter++;
                }
            }
        }

        private static string RevercedWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecilaCharacters(string currentLine)
        {
            return currentLine.Replace("-","@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
