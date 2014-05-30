//(task 3)Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToHex
{
   public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            ConvertDecToHex(number);
        }

        static void PrintResult(string result)
        {
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }

        static void ConvertDecToHex(int number)
        {
            StringBuilder sb = new StringBuilder();
            if (number != 0)
            {
                while (number != 0)
                {
                    int digit = number % 16;
                    sb.Append(GetHexDigit(digit));
                    number /= 16;
                }
            }
            else
            {
                sb.Append(0);
            }
            PrintResult(sb.ToString());
        }

        public static string GetHexDigit(int digit)
        {
            string result = string.Empty;
            switch (digit)
            {
                case 0:
                    result = "0";
                    break;
                case 1:
                    result = "1";
                    break;
                case 2:
                    result = "2";
                    break;
                case 3:
                    result = "3";
                    break;
                case 4:
                    result = "4";
                    break;
                case 5:
                    result = "5";
                    break;
                case 6:
                    result = "6";
                    break;
                case 7:
                    result = "7";
                    break;
                case 8:
                    result = "8";
                    break;
                case 9:
                    result = "9";
                    break;
                case 10:
                    result = "A";
                    break;
                case 11:
                    result = "B";
                    break;
                case 12:
                    result = "C";
                    break;
                case 13:
                    result = "D";
                    break;
                case 14:
                    result = "E";
                    break;
                case 15:
                    result = "F";
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            return result;
        }
    }
}
