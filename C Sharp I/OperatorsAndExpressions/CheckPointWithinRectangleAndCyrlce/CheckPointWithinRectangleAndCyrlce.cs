//(task 9)Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointWithinRectangleAndCyrlce
{
    class CheckPointWithinRectangleAndCyrlce
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an expression that checks for given point (x, y)\nif it is within the circle K( (1,1), 3) and out \nof the rectangle R(top=1, left=-1, width=6, height=2).");
            Console.Write("\nEnter point X: ");
            double xPoint = double.Parse(Console.ReadLine());
            Console.Write("Enter point Y: ");
            double yPoint = double.Parse(Console.ReadLine());

            double circleCenterX = 1;
            double circleCenterY = 1;
            double circleRadius = 3;

            if ((Math.Pow((xPoint - circleCenterX), 2) + Math.Pow((yPoint - circleCenterY), 2)) <= Math.Pow(circleRadius, 2)) //check if                                                                                        pointx,y is in the circle
            {
                Console.WriteLine("\nPoint X({0}) and Y({1}) is within the circle(({2},{3}),{4})", xPoint, yPoint,
                    circleCenterX, circleCenterY, circleRadius);
            }
            else
            {
                Console.WriteLine("\nPoint X({0}) and Y({1}) is out of the circle(({2},{3}),{4})", xPoint, yPoint,
                    circleCenterX, circleCenterY, circleRadius);
            }
            Console.WriteLine("And");

            if ((xPoint >= (-1) && xPoint <= 5) && (yPoint <= 1 && yPoint >= (-1))) // check if point x is in the rectangel
            {
                Console.WriteLine("Point X({0}) and Y({1}) is in the rectangle R(1,-1,6,2))", xPoint, yPoint);
            }
            else
            {
                Console.WriteLine("Point X({0}) and Y({1}) is out of the rectangle R(1,-1,6,2))", xPoint, yPoint);
            }

        }
    }
}
