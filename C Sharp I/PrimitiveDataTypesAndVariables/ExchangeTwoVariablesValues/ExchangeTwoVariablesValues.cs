//(Task 11)Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

namespace ExchangeTwoVariablesValues
{
    class ExchangeTwoVariablesValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: a: {0}    b: {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After: a: {0}  b: {1}", a, b);
        }
    }
}
