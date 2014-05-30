//(Task 1)Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminTwoIntegers
{
    class ExaminTwoIntegers
    {
        static void Main(string[] args)
        {
            int firstVal = int.Parse(Console.ReadLine());
            int secondVal = int.Parse(Console.ReadLine());
            int tmpVal = firstVal;
            if (firstVal > secondVal)
            {
                firstVal = secondVal;
                secondVal = tmpVal;
            }
            Console.WriteLine("first value ->  {0}\nsecond value -> {1}", firstVal, secondVal);
        }
    }
}
