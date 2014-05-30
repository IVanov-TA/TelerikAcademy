//(task 24)Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticOrderedWords
{
    class AlphabeticOrderedWords
    {
        static void Main()
        {
            string words = Console.ReadLine();
            string[] sepWords = words.Split(new char[] { ' ', ',', '.', '?', '/', '!', '>', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(sepWords);

            foreach (var item in sepWords)
            {
                Console.WriteLine(item);
            }

        }
    }
}
