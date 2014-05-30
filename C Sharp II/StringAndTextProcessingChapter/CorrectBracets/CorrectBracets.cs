/*(task 3)Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBracets
{
    class CorrectBracets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0}", CheckResult(CheckCountOfBrackets(input))? "Brackets are correct!" : "Not correct brackets!");
        }

        static int CheckCountOfBrackets(string text)
        {
            int brackets = 0;

            foreach (var item in text)
            {
                if (item == '(')
                {
                    brackets++;
                }
                if (item == ')')
                {
                    brackets--;
                }
            }

            return brackets;
        }

        static bool CheckResult(int result)
        {
            return result == 0 ? true : false;
        }
    }
}
