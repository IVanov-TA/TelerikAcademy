//(Task 1) Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.


using System;


namespace ProperTypeOfFiveVariables
{
    class ProperTypeOfFiveVariables
    {
        static void Main()
        {
            ushort firstVal = 52130;
            sbyte secondVal = -115;
            int thirdVal = 4825932;
            byte forthVal = 97;
            short fifthVal = -10000;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstVal, secondVal, thirdVal, forthVal, fifthVal);
        }
    }
}
