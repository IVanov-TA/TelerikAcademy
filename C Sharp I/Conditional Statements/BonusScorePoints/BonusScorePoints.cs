//(task 10)Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.Use a switch statement and at the end print the calculated new value in the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScorePoints
{
    class BonusScorePoints
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();

            int input;
            bool isDigit = int.TryParse(input1, out input);
            if (!isDigit)
            {
                Console.WriteLine("INVALID INPUT :(");
            }
            else
            {
                switch (input)
                {
                    case 1:
                    case 2:
                    case 3:
                        input *= 10;
                        Console.WriteLine(input);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        input *= 100;
                        Console.WriteLine(input);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        input *= 1000;
                        Console.WriteLine(input);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT :(");
                        break;
                }
            }
        }
    }
}
