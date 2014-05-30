//(task 5) Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBin
{
    class HexToBin
    {
        static void Main()
        {
            string hexNum = Console.ReadLine().ToUpper();
            ConvertHexToBin(hexNum);
        }

        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        static void ConvertHexToBin(string hexNum)
        {
            string result = string.Empty;
            foreach (var digit in hexNum)
            {
                result += GetBinRepresentation(digit);
            }
            PrintResult(result);
        }

        static string GetBinRepresentation(char digit)
        {
            string binStr = string.Empty;
            switch (digit)
            {
                case '0': binStr = "0000"; break;
                case '1': binStr = "0001"; break;
                case '2': binStr = "0010"; break;
                case '3': binStr = "0011"; break;
                case '4': binStr = "0100"; break;
                case '5': binStr = "0101"; break;
                case '6': binStr = "0110"; break;
                case '7': binStr = "0111"; break;
                case '8': binStr = "1000"; break;
                case '9': binStr = "1001"; break;
                case 'A': binStr = "1010"; break;
                case 'B': binStr = "1011"; break;
                case 'C': binStr = "1100"; break;
                case 'D': binStr = "1101"; break;
                case 'E': binStr = "1110"; break;
                case 'F': binStr = "1111"; break;
                default: binStr = ""; break;
            }

            return binStr;
        }
    }
}
