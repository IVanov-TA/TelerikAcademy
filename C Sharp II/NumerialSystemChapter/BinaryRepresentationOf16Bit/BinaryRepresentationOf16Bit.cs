//(task 8)Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRepresentationOf16Bit
{
    class BinaryRepresentationOf16Bit
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            string result = string.Empty;

            if (number >= 0)
            {
                result = PositiveBinRepresentation(number);
                result = result.PadLeft(result.Length + (16 - result.Length), '0');
            }
            else
            {
                result = NegativeBinRepresentataion(number);
                result = "1" + result.PadLeft(result.Length + (16 - result.Length-1), '0');
            }

            Console.WriteLine(result);
        }

        static string PositiveBinRepresentation(int number)
        {
            string result = string.Empty;

            while (number != 0)
            {
                int digit = number % 2;
                result += digit;
                number /= 2;
            }
            return ReverseBinaryResult(result);
        }

        static string NegativeBinRepresentataion(int number)
        {
            string result = string.Empty;
            int tmpNum = short.MaxValue - Math.Abs(number) + 1;
            result = PositiveBinRepresentation(tmpNum);
            return result;
        }

        static string ReverseBinaryResult(string number)
        {
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
