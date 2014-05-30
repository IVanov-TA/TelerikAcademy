/*(task 2)Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumberMethod
{
    class ReadNumberMethod
    {
        static int count = 0;

        static void Main()
        {
            ReadeNumber(1, 100);
        }

        static int ReadeNumber(int start, int end)
        {
            int number = 0;

            try
            {
                Console.Write("Enter number {0} in the range {1} - {2}: -> ", count + 1, start, end);
                number = int.Parse(Console.ReadLine());
                count++;

                if (count == 10)
                {
                    return number;
                }

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number {2} is not in the range {0} - {1}.", start, end, number);
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid number.");
                return 0;
            }

            return ReadeNumber(number, end);
        }
    }
}
