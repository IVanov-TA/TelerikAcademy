//Write a program that reads 3 integer numbers from the console and prints their sum.


using System;

namespace ReadPrintThreeIntg
{
    class ReadPrintThreeIntg
    {
        static void Main()
        {
            int a, b, c;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of {0} {1} {2} is {3}", a, b, c, a + b + c);
        }
    }
}
