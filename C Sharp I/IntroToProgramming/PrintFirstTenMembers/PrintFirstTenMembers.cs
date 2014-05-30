//(Task 9)Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

namespace PrintFirstTenMembers
{
    class PrintFirstTenMembers
    {
        static void Main()
        {
            sbyte digit = 2;
            Console.Write(digit);

            for (int i = 1; i < 10; i++)
            {
                int result = digit + i;
                Console.Write(", "); //print comma and space afte each digit

                if (result % 2 == 0) //check if the number is even 
                {
                    Console.Write(result);
                }
                else
                {
                    result *= -1; //if number is not even multuply with -1 to make number negative
                    Console.Write(result);
                }
                result = 0;

            }
            Console.WriteLine();
        }
    }
}
