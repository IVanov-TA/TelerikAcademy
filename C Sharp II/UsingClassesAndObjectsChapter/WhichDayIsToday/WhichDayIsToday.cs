//(task 3)Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichDayIsToday
{
    class WhichDayIsToday
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString("dddd"));
        }
    }
}
