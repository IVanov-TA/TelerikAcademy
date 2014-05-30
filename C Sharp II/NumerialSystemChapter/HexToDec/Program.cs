//(task 4) Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    public class Program
    {
        static void Main()
        {
            string hexNum =  Console.ReadLine().ToUpper();
            ConvertHexToDec(hexNum);
        }

        static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }

        static void ConvertHexToDec(string hexNum)
        {
            int power = hexNum.Length - 1;
            int result = 0;

            for (int i = 0; i < hexNum.Length; i++, power--)
            {
                result += GetDecimalRepresentation(hexNum[i]) * (int)Math.Pow(16, power);
            }
            PrintResult(result);
        }

        public static int GetDecimalRepresentation(char lastChar)
        {
            int digit = int.MinValue;
            switch (lastChar)
            {
                case '0':
                    digit = 0;
                    break;
                case '1':
                    digit = 1;
                    break;
                case '2':
                    digit = 2;
                    break;
                case '3':
                    digit = 3;
                    break;
                case '4':
                    digit = 4;
                    break;
                case '5':
                    digit = 5;
                    break;
                case '6':
                    digit = 6;
                    break;
                case '7':
                    digit = 7;
                    break;
                case '8':
                    digit = 8;
                    break;
                case '9':
                    digit = 9;
                    break;
                case 'A':
                    digit = 10;
                    break;
                case 'B':
                    digit = 11;
                    break;
                case 'C':
                    digit = 12;
                    break;
                case 'D':
                    digit = 13;
                    break;
                case 'E':
                    digit = 14;
                    break;
                case 'F':
                    digit = 15;
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
            return digit;
        }
    }
}
