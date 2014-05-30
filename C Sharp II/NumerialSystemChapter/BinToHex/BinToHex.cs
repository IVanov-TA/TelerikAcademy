//(task 6) Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class BinToHex
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();

            if (binNumber.Length % 4 != 0)
            {
                binNumber = GetProperLenght(binNumber);
            }
            Console.WriteLine(binNumber);
            ConvertBinToHex(binNumber);
        }

        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        static void ConvertBinToHex(string number)
        {
            string result = string.Empty;

            for (int i = 0; i < number.Length; i += 4)
            {
                result += GetHexDigit(number.Substring(i, 4));
            }
            PrintResult(result);
        }

        static string GetProperLenght(string number)
        {
            string result = number.PadLeft(number.Length + (4 - (number.Length % 4)), '0');
            return result;
        }

        static string GetHexDigit(string digit)
        {
            string res = string.Empty;
            switch (digit)
            {
                case "0000": res = "0"; break;
                case "0001": res = "1"; break;
                case "0010": res = "2"; break;
                case "0011": res = "3"; break;
                case "0100": res = "4"; break;
                case "0101": res = "5"; break;
                case "0110": res = "6"; break;
                case "0111": res = "7"; break;
                case "1000": res = "8"; break;
                case "1001": res = "9"; break;
                case "1010": res = "A"; break;
                case "1011": res = "B"; break;
                case "1101": res = "D"; break;
                case "1110": res = "E"; break;
                case "1111": res = "F"; break;
                default: res = ""; break;
            }

            return res;
        }
    }
}
