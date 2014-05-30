//(task 22)Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiffWordsInText
{
    class CountDiffWordsInText
    {
        static void Main()
        {
            string text = "this is simple text, this, that, what, what of ttttt anndd sss oorr ddd";
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
            CountDifferentWords(words);
        }

        static void CountDifferentWords(string[] text)
        {
            List<string> words = new List<string>();
            List<int> counted = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!WordIsCounted(words, text[i]))
                {
                    words.Add(text[i]);
                    int tmpCount = 0;
                    int index = i;

                    while (Array.IndexOf(text, text[i], index) != -1)
                    {
                        tmpCount++;
                        index++;
                    }
                    counted.Add(tmpCount);
                }
            }

            PrintResult(words, counted);
        }

        static void PrintResult(List<string> words, List<int> counted)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", words[i], counted[i]);
            }
        }

        static bool WordIsCounted(List<string> digits, string word)
        {
            if (digits.IndexOf(word) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
