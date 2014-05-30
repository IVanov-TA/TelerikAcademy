//(task 3) Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitToWord
{
    class LastDigitToWord
    {
        static void Main()
        {
            GetData();
        }

        static void GetLastDigit(int number)
        {
            int digit = Math.Abs(number % 10);
            PrintWord(digit);
        }

        static void GetData()
        {
            Console.Write("Please enter some number: ");
            int number = int.Parse(Console.ReadLine());
            GetLastDigit(number);
        }
        static void PrintWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("MISTAKE !!!");
                    break;
            }
        }
    }
}
