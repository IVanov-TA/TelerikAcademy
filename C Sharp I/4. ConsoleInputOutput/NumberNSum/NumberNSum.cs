//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 


using System;

namespace NumberNSum
{
    class NumberNSum
    {
        static void Main()
        {
            Console.Write("n = ");
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            double sum = 0;
            for (int counter = 0; counter < n; counter++)
            {
                Console.WriteLine("Input number for summing");
                Console.Write("x = ");
                string xString = Console.ReadLine();
                double x = double.Parse(xString);
                sum += x;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
