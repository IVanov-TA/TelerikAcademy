//(task 2)Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReverseString
{
    class ReadReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }

        static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
