namespace _06.PrintAllNumDivisible3and7
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] array = { 1, 3, 231, 7, 21, 42, 56, 73, 63, 210 };

            // With lambda expression
            Console.WriteLine("Lambda expression\n");
            int[] ourNumbers = Array.FindAll(array, num => num % 21 == 0);
            foreach (int num in ourNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nLinq\n");

            // With LINQ
            var ourNumbersnext =
                from num in array
                where num % 21 == 0
                select num;
            foreach (int num in ourNumbersnext)
            {
                Console.WriteLine(num);
            }
        }
    }
}
