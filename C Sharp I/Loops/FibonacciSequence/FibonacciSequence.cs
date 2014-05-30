//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


using System;
using System.Numerics;

namespace FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N number:");
            int n = int.Parse(Console.ReadLine());          
            BigInteger currentMember = 0;
            BigInteger sum = 0;
            BigInteger first = 0;
            BigInteger second = 1;
            for (int i = 2; n > i; i++)
            {
                currentMember=first+second;
                first = second;
                second = currentMember;              
                sum += currentMember;
            }
            Console.WriteLine("The sum is : {0}",sum+1);
        }
    }
}
