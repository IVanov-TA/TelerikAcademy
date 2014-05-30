/*(task 6)You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStringSum
{
    class CalculateStringSum
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            double result = 0;

            foreach (var number in numbers)
            {
                double num = 0;
                if (double.TryParse(number,out num))
                {
                    result += num;
                }
            }

            Console.WriteLine(result);
        }
    }
}
