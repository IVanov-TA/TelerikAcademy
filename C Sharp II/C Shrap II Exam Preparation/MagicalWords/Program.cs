using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Words
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            var word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                word = words[i];
                int index = GetPosition(word.Length, n);

                words[i] = null;
                words.Insert(index, word);
                words.Remove(null);
            }

            PrintResult(words);
        }

        static int GetPosition(int lenght, int n)
        {
            int index = lenght % (n + 1);
            return index;
        }

        static void PrintResult(List<string> words)
        {
            var result = new StringBuilder();

            int maxLenght = words.Max(s => s.Length);

            for (int i = 0; i < maxLenght; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(result.ToString().ToLower());
        }

    }
}
