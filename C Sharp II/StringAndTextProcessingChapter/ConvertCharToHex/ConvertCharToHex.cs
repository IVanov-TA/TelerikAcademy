//(task 10)Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCharToHex
{
    class ConvertCharToHex
    {
        static void Main()
        {
            string text = "Hello world!";
            Console.WriteLine(text);

            foreach (var letter in text)
            {
                Console.Write("\\u{0:X4}", (int)letter);
            }

            Console.WriteLine();
        }
    }
}
