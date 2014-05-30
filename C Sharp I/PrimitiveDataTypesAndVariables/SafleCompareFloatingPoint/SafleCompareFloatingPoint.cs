//(Taks 3)Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

namespace SafleCompareFloatingPoint
{
    class SafleCompareFloatingPoint
    {
        static void Main()
        {
            //type is float because we are comparing values till seven digit after float point
            float firstVal = float.Parse(Console.ReadLine());
            float secondVal = float.Parse(Console.ReadLine());

            bool isEqual = (firstVal == secondVal);
            Console.WriteLine("a == b : {0}", isEqual? true:false); //print the result
        }
    }
}
