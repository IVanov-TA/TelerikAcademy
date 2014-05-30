//(task 7)Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).


using System;
using DecToHex;
using HexToDec;

namespace ConvertFromAnySystem
{
    class ConvertFromAnySystem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            string number = Console.ReadLine().ToUpper();
            Console.Write("Now tell me wich numeral system is this: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.Write("In what numeral system do you want to convert it: ");
            int base2 = int.Parse(Console.ReadLine());

            if (CheckForProperBases(base1, base2))
            {
                int convertedFromBase1 = ConvertFromAnyToDec(number, base1);
                string convertedToBase2 = ConvertFromDecToAny(convertedFromBase1, base2);
                Console.WriteLine(convertedToBase2);
            }
            else
            {
                Console.WriteLine("Sorry Bases must be 2<=s & d<=16");
            }
        }

        static string ConvertFromDecToAny(int dec, int base2)
        {
            string result = string.Empty;

            while (dec != 0)
            {
                int digit = dec % base2;

                //using method GetHexDigit from task 03 in the sln
                result += DecToHex.Program.GetHexDigit(digit);
                dec /= base2;
            }

            return ReversingTheResult(result);
        }

        static string ReversingTheResult(string result)
        {
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static int ConvertFromAnyToDec(string number, int base1)
        {
            int dec = 0;
            int power = number.Length - 1;
            for (int i = 0; i < number.Length; i++, power--)
            {
                dec += HexToDec.Program.GetDecimalRepresentation(number[i]) * (int)Math.Pow(base1, power);
            }

            return dec;
        }

        static bool CheckForProperBases(int base1, int base2)
        {
            if (base1 >= 2 && base2 <= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
