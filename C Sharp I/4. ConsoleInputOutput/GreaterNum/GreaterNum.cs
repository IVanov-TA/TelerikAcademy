//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


using System;

namespace GreaterNum
{
    class GreaterNum
    {
        static void Main()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Math.Max(num1, num2);
            Console.WriteLine("The greater number of {0} and {1} is {2}", num1, num2, result);
        }
    }
}
