//(task 1)Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class DecToBin
    {
        static void Main()
        {
            //get user input
            int input = int.Parse(Console.ReadLine());

            //using method for convertin from dec to bin
            ConvertDecToInt(input);
        }

        static void ConvertDecToInt(int number)
        {
            StringBuilder sb = new StringBuilder();
            while (number != 0)
            {
                int reminder = number % 2;
                sb.Append(reminder);
                number /= 2;
            }
            ReverseString(sb.ToString());
        }

        static void ReverseString(string result) 
        {
            char[] arr = result.ToArray();
            Array.Reverse(arr);
            PrintResult(new string(arr));

        }

        static void PrintResult(string result) 
        {
            Console.WriteLine(result);
        }
    }
}
