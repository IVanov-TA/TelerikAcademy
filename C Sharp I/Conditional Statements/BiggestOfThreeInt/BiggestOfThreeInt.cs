//(task 03)Write a program that finds the biggest of three integers using nested if statements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeInt
{
    class BiggestOfThreeInt
    {
        static void Main(string[] args)
        {
            int firstVal = int.Parse(Console.ReadLine());
            int secondVal = int.Parse(Console.ReadLine());
            int thirdVal = int.Parse(Console.ReadLine());
            int greater = firstVal;

            if (secondVal > firstVal)
            {
                if (secondVal > thirdVal)
                {
                    greater = secondVal;
                }
                else
                {
                    greater = thirdVal;
                }
            }
            else
            {
                if (thirdVal > firstVal)
                {
                    greater = thirdVal;
                }
            }
            Console.WriteLine("Greater number is {0}", greater);
        }
    }
}
