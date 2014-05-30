using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWorkingDays
{
    class NumberOfWorkingDays
    {
        public static HashSet<DateTime> holidays = new HashSet<DateTime>();
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is {0} {1}.", today, today.DayOfWeek);
            Console.Write("Input future date in the same format, as the output above: ");
            DateTime finalDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your future date is {0} {1}.", finalDay, finalDay.DayOfWeek);
            int daysDifference = (finalDay - today).Days;
            if (daysDifference < 1)
            {
                Console.WriteLine("You had to choose future date - at least one day after today!");
                return;
            }
            int holidaysFrequancy = 15;
            GenerateHolydays(today, finalDay, daysDifference, holidaysFrequancy);
            Console.WriteLine("DayDifference {0}", daysDifference);
            foreach (DateTime element in holidays)
            {
                Console.WriteLine("Holyday : {0} {1}", element, element.DayOfWeek);
            }

            int workingDaysCount = 0;
            while ((daysDifference + 1) % 7 != 0)
            {
                if (today.DayOfWeek != DayOfWeek.Sunday && today.DayOfWeek != DayOfWeek.Saturday &&
                    !holidays.Contains(today))
                {
                    workingDaysCount++;
                }
                if (holidays.Contains(today))
                {
                    holidays.Remove(today);
                }
                today = today.AddDays(1);
                daysDifference = (finalDay - today).Days;
            }
            workingDaysCount += ((daysDifference + 1) / 7) * 5;
            workingDaysCount -= holidays.Count;
            Console.WriteLine("There {1} {0} working day{2} in that period.",
                workingDaysCount, workingDaysCount == 1 ? "is" : "are", workingDaysCount == 1 ? "" : "s");
        }

        private static void GenerateHolydays(DateTime today, DateTime finalDay, int dayDifference, int holidaysFrequancy)
        {
            Random rand = new Random();
            for (int i = 0; i < dayDifference; i += holidaysFrequancy)
            {
                DateTime holidayCandidate = today.AddDays(i + rand.Next(holidaysFrequancy));
                if ((holidayCandidate >= today && holidayCandidate <= finalDay) &&
                    holidayCandidate.DayOfWeek != DayOfWeek.Saturday &&
                    holidayCandidate.DayOfWeek != DayOfWeek.Sunday)
                {
                    holidays.Add(holidayCandidate);
                }
            }
        }
    }
}
