//(task 4) Sort 3 real values in descending order using nested if statements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeValues
{
    class SortThreeValues
    {
        static void Main(string[] args)
        {
            int firstVal = int.Parse(Console.ReadLine());
            int secondVal = int.Parse(Console.ReadLine());
            int thirdVal = int.Parse(Console.ReadLine());

            int positionOne = firstVal;
            int positionTwo = secondVal;
            int positionThree = thirdVal;

            if (secondVal > firstVal)
            {
                if (secondVal > thirdVal)
                {
                    positionOne = secondVal;

                    if (thirdVal > firstVal)
                    {
                        positionTwo = thirdVal;
                        positionThree = firstVal;
                    }
                    else
                    {
                        positionTwo = firstVal;
                        positionThree = thirdVal;
                    }
                }
                else
                {
                    positionOne = thirdVal;
                    positionTwo = secondVal;
                    positionThree = firstVal;
                }
            }
            else if (thirdVal > firstVal)
            {
                positionOne = thirdVal;
                positionTwo = firstVal;
                positionThree = secondVal;
            }
            else
            {
                if (thirdVal > secondVal)
                {
                    positionTwo = thirdVal;
                    positionThree = secondVal;
                }
            }
            Console.WriteLine("\n{0}\n{1}\n{2}", positionOne, positionTwo, positionThree);
        }
    }
}
