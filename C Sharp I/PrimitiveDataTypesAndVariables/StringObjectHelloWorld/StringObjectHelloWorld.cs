//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace StringObjectHelloWorld
{
    class StringObjectHelloWorld
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object result = firstWord + " " + secondWord;
            string getResultObject = (string)result;
            Console.WriteLine(getResultObject);
        }
    }
}
