//(Task 2)Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

namespace FloatDoubleVariables
{
    class FloatDoubleVariables
    {
        static void Main()
        {
            double firstVal = 34.567839023;
            float secondVal = 12.345f;
            double thirdVal = 8923.1234857;
            float fourthVal = 3456.091f;
            Console.WriteLine("{0}, {1}, {2}, {3}", firstVal, secondVal, thirdVal, fourthVal);
        }
    }
}
