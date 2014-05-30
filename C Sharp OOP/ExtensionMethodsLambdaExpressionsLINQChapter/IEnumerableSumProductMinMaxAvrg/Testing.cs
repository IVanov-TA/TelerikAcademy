namespace IEnumerableSumProductMinMaxAvrg
{
    using System;
    using System.Collections.Generic;

    public class Testing
    {
        public static void Main()
        {
            List<int> testInts = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            byte[] testByte = new byte[] { 1, 2, 3, 4, 5 };
            decimal[] testDecimal = new decimal[] { 1.0m, 2.5m, 4.5m, 7.5m, 11m };
            string[] testString = new string[] { "asd", "mtgs", "caa" };

            // testing Sum
            Console.WriteLine();
            Console.WriteLine("Testing Sum-----------------------------------------------");
            Console.WriteLine();

            int sumInts = testInts.Sum();
            Console.WriteLine(sumInts);

            byte sumBytes = testByte.Sum();
            Console.WriteLine(sumBytes);

            decimal sumDecimal = testDecimal.Sum();
            Console.WriteLine(sumDecimal);

            string sumStrings = testString.Sum();
            Console.WriteLine(sumStrings);

            // testing Product
            Console.WriteLine();
            Console.WriteLine("Testing Product-----------------------------------------------");
            Console.WriteLine();

            int prodInts = testInts.Product();
            Console.WriteLine(prodInts);

            byte prodBytes = testByte.Product();
            Console.WriteLine(prodBytes);

            decimal prodDecimal = testDecimal.Product();
            Console.WriteLine(prodDecimal);

            // testing Average
            Console.WriteLine();
            Console.WriteLine("Testing Average-----------------------------------------------");
            Console.WriteLine();

            int averageInts = testInts.Average();
            Console.WriteLine(averageInts);

            byte averageBytes = testByte.Average();
            Console.WriteLine(averageBytes);

            decimal averageDecimal = testDecimal.Average();
            Console.WriteLine(averageDecimal);

            // testing Min
            Console.WriteLine();
            Console.WriteLine("Testing Min-----------------------------------------------");
            Console.WriteLine();

            int minInts = testInts.GetMin();
            Console.WriteLine(minInts);

            byte minBytes = testByte.GetMin();
            Console.WriteLine(minBytes);

            decimal minDecimal = testDecimal.GetMin();
            Console.WriteLine(minDecimal);

            string minStrings = testString.GetMin();
            Console.WriteLine(minStrings);

            // testing max
            Console.WriteLine();
            Console.WriteLine("Testing max-----------------------------------------------");
            Console.WriteLine();

            int maxInts = testInts.GetMax();
            Console.WriteLine(maxInts);

            byte maxBytes = testByte.GetMax();
            Console.WriteLine(maxBytes);

            decimal maxDecimal = testDecimal.GetMax();
            Console.WriteLine(maxDecimal);

            string maxStrings = testString.GetMax();
            Console.WriteLine(maxStrings);
        }
    }
}
