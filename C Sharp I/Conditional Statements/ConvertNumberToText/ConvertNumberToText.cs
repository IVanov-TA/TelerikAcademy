/*(task 11*) * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToText
{
    class ConvertNumberToText
    {
        static void Main(string[] args)
        {
            string[] ones = new String[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tens = new String[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] specialDigits = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string input = Console.ReadLine();
            input = input.TrimStart('-'); //reverse the negative value
            if (input.Length == 1)
            {
                int digit = int.Parse(input);
                if (digit == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    Console.WriteLine(ones[digit]);
                }
            }
            else if (input.Length == 2)
            {
                int value = int.Parse(input);

                if (value > 9 && value < 20)
                {
                    value -= 10;
                    Console.WriteLine(specialDigits[value]);
                }
                else
                {
                    int firstDigit = value % 10;
                    value /= 10;
                    int secondDigit = value % 10;
                    Console.WriteLine("{0} {1}", tens[secondDigit], ones[firstDigit]);
                }
            }
            else if (input.Length == 3)
            {
                int value = int.Parse(input);
                int hundreds = value / 100;
                int lastTwo = value % 100;

                if (lastTwo < 10)
                {
                    lastTwo %= 10;
                    Console.WriteLine(ones[hundreds] + " hudred and " + ones[lastTwo]);
                }
                else if (lastTwo > 9 && lastTwo < 20)
                {
                    lastTwo -= 10;
                    Console.WriteLine(ones[hundreds] + " hudred and " + specialDigits[lastTwo]);
                }
                else
                {
                    int lastDigit = lastTwo % 10;
                    int secondDigit = lastTwo /10;
                    Console.WriteLine(ones[hundreds] + " hudred " + tens[secondDigit] + " " + ones[lastDigit]);
                }
            }
            else
            {
                Console.WriteLine("To large number I guess...");
            }
        }
    }
}
