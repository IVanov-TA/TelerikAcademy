//(task 2)Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideSevenAndFive
{
    class DivideSevenAndFive
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool result = false;
            if ((input % 5 == 0) || (input % 7 == 0))
            {
                result = true;
            }
            Console.WriteLine(result);
        }
    }
}
