//(task 21)Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiffLettersInText
{
    class CountDiffLettersInText
    {
        static void Main()
        {
            string text = "this is simple text of ttttt anndd sss oorr ddd";
            CountDifferentLetters(text);

        }

        static void CountDifferentLetters(string text)
        {
            List<char> digits = new List<char>();
            List<int> counted = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {

                if (!DigitIsCounted(digits, text[i]))
                {
                    digits.Add(text[i]);
                    int tmpCount = 0;
                    int index = 0;

                    while ((index = text.IndexOf(text[i], index)) != -1)
                    {
                        tmpCount++;
                        index++;
                    }
                    counted.Add(tmpCount);
                }

            }

             PrintResult(digits, counted);
        }

        static void PrintResult(List<char> digits, List<int> counted) 
        {
            for (int i = 0; i < digits.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", digits[i], counted[i]);
            }
        }

        static bool DigitIsCounted(List<char> digits, char digit)
        {
            if (digits.IndexOf(digit) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
