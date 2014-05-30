using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Justification
{
    class Program
    {
        static void Main()
        {
            int totalNumofInitialText = int.Parse(Console.ReadLine());

            int numberOfSymbolsPerLine = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            var inputText = new StringBuilder();
            int countedLetters = 0;
            for (int i = 0; i < totalNumofInitialText; i++)
            {
                string tmp = Console.ReadLine();
                string[] textLine = tmp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < tmp.Length; j++)
                {
                    if (char.IsLetterOrDigit(tmp[j]))
                    {
                        countedLetters++;
                    }
                }

                foreach (var word in textLine)
                {
                    words.Add(word);
                    inputText.Append(word);
                    inputText.Append(' ');
                }
            }

            ProcessTheText(words, numberOfSymbolsPerLine);
        }

        private static void ProcessTheText(List<string> words, int widthOfLine)
        {
            var result = new StringBuilder();
            int tmpcount = 0;
            foreach (var word in words)
            {
                while (tmpcount < widthOfLine)
                {
                    tmpcount += word.Length + 1;
                }
            }
        }
    }
}
