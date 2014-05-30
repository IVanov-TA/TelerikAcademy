//(task 19)Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExctractDatesFromText
{
    class ExctractDatesFromText
    {
        static void Main(string[] args)
        {
            string input = "22.22.2012 hello 12.02.2011 not a 01.01.1990";

            string regex = @"((((0?[1-9])|[12][0-9]|3[01])\.((0?[13578])|(1[02])))|(((0?[1-9])|[12][0-9]|30)\.((0?[469])|11))|(((0?[1-9])|[12][0-9])\.(0?2)))\.\d{4}";

            DateTime date;

            foreach (Match item in Regex.Matches(input, regex))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }

        }
    }
}
