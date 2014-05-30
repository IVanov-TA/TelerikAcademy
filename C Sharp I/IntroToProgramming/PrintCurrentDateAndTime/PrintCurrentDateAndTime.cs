//(Task 7)Create a console application that prints the current date and time.

using System;

namespace PrintCurrentDateAndTime
{
    class PrintCurrentDateAndTime
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}
