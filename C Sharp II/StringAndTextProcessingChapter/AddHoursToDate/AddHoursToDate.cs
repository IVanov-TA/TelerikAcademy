﻿//(task 17)Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddHoursToDate
{
    class AddHoursToDate
    {
        static void Main()
        {
            string str = Console.ReadLine();
            DateTime date = DateTime.ParseExact(str, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddMinutes(390);

            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}
