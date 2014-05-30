//(task 13)Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class ReverseWords
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            string[] sign = text.Split(words, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < sign.Length; i++)
            {
                res.Append(words[i]);
                res.Append(sign[i]);
            }
            Console.WriteLine(res.ToString());
        }
    }
}
