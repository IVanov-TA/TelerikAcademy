namespace Methods.Utilities
{
    using System;

    public class NumberUtility
    {
        private static readonly string[] DigitNames =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        public static string GetDigitName(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentException("Digit must be in range [0; 9]");
            }

            return DigitNames[digit];
        }

        public static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintWithFixedPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintWithRightAlignment(object number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}
