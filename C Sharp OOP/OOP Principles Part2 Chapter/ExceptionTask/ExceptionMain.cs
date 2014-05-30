namespace ExceptionTask
{
    using System;

    public class ExceptionMain
    {
        public static void Main()
        {
            int start = 1, end = 100;
            DateTime startDate = new DateTime(1980, 1, 1), endDate = new DateTime(2013, 12, 31);

            try
            {
                int number = CheckNumber(start, end);

                // if there are no errors it will print the number
                Console.WriteLine(number);
            }
            catch (InvalidRangeException<int> e)
            {
               Console.WriteLine("{0} {1} -> {2}", e.Message, e.Start, e.End);
            }

            try
            {
                DateTime date = CheckDate(startDate, endDate);

                // if there are no error it will print the date
                Console.WriteLine(date.ToShortDateString());
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0} {1} -> {2}", e.Message, e.Start.ToShortDateString(), e.End.ToShortDateString());
            }
        }

        public static int CheckNumber(int start, int end)
        {
            Console.WriteLine("Limits are {0} - {1}", start, end);
            int input = int.Parse(Console.ReadLine());
            if (input < start || input > end)
            {
                throw new InvalidRangeException<int>("Int Limits are", start, end);
            }

            return input;
        }

        public static DateTime CheckDate(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("Date limits are {0} - {1}", startDate.ToShortDateString(), endDate.ToShortDateString());
            DateTime input = DateTime.Parse(Console.ReadLine());
            if (input < startDate || input > endDate)
            {
                throw new InvalidRangeException<DateTime>("Date limits are", startDate, endDate);
            }

            return input;
        }
    }
}
