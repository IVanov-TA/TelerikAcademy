//(Task 13)Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

namespace NullValToIntDouble
{
    class NullValToIntDouble
    {
        static void Main()
        {
            int? value1 = null;
            double? value2 = null;
            Console.WriteLine("int?: {0}    double?: {1}", value1, value2);
            value1 += null;
            value2 += 123.323232;
            Console.WriteLine("\nint?+=null: {0}    double?+=123.323232: {1}", value1, value2);
        }
    }
}
