using System;
using System.IO;
using System.Linq;

namespace Problem2LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {

            //        text.txt                                                   output.txt
            //- I was quick to judge him, but it wasn't his fault.   Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
            //- Is this some kind of joke?!Is it?                    Line 2: -Is this some kind of joke?!Is it ? (24)(4)
            //- Quick, hide here. It is safer.                       Line 3: -Quick, hide here. It is safer. (22)(4)

            string textPath = "text.txt";
            string outputPath = "output.txt";

            string[] textLines = File.ReadAllLines(textPath);
            int lineCounter = 1;

            foreach (var currentLine in textLines)
            {
                int letersCount = currentLine.Count(char.IsLetter);
                int puncsCount = currentLine.Count(char.IsPunctuation);

                File.AppendAllText(outputPath, $"Line {lineCounter}: {currentLine} ({letersCount})({puncsCount}){Environment.NewLine}");

                lineCounter++;
            }

        }
    }
}
