//(Task 8)Create a console application that calculates and prints the square of the number 12345.

using System;

namespace CalculatePrintSquare
{
    class CalculatePrintSquare
    {
        static void Main()
        {
            int num = 12345; //create variable
            int result = num * num; //square the variable
            Console.WriteLine("Result of square 12345 is: {0}", result); //print the result
        }
    }
}
