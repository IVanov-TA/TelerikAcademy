/*(task 6)Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prdoubles its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquasion
{
    class QuadraticEquasion
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            double x1, x2;
            if (D < 0)
            {
                Console.WriteLine("The equasion have no real roots");
            }
            if (D == 0)
            {
                x1 = (b * -1) / (2 * a);
                Console.WriteLine("The equasion have one real root x1 = {0}", x1);
            }
            if (D > 0)
            {
                x1 = ((b * -1) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                x2 = ((b * -1) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                Console.WriteLine("The equasion have two real roots x1= ({0});  x2= ({1})", x1, x2);
            }
        }
    }
}
