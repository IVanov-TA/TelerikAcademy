//(task 16) Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNumberOfDays
{
    class CalculateNumberOfDays
    {
        static void Main()
        {
            Console.WriteLine("Enter date: ");

            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write("date {0}: ", i + 1);
                dates.Add(DateTime.Parse(Console.ReadLine()));
            }
            Console.WriteLine(CountDays(dates));
        }

        static double CountDays(List<DateTime> dates) 
        {
            double days = Math.Abs((dates[0] - dates[1]).TotalDays);
            return days;
        }
    }
}
