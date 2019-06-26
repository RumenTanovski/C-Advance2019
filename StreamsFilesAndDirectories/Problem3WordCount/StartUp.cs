using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem3WordCount
{
    class StartUp
    {
        static void Main(string[] args)
        {


            string textPath = "text.txt";
            string wordsPath = "words.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordsPath);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWordLowerCase = word.ToLower();
                if (!wordsInfo.ContainsKey(currentWordLowerCase))
                {
                    wordsInfo.Add(currentWordLowerCase, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] {' ', '-',',','.','?','!','\'',':', ';' });

                foreach (var currentWord in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }

            string actualRezultPath = "actualResult.txt";
            string expectedRezultPath = "expectedResult.txt";


            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualRezultPath, $"{key} - {value}{Environment.NewLine}");                
                //Console.WriteLine($"{key} - {value}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedRezultPath, $"{key} - {value}{Environment.NewLine}");
                //Console.WriteLine($"{key} - {value}");
            }
        }
    }
}
