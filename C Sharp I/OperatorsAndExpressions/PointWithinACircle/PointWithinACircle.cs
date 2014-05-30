//(task 6)Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointWithinACircle
{
    class PointWithinACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 5;

            if ((x * x + y * y) <= radius * radius)
            {
                Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K(0,5)", x, y);

            }
            else
            {
                Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K(0,5)", x, y);
            }
        }
    }
}
