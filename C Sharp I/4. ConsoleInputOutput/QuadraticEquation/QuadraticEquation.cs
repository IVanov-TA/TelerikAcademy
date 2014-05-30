//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;

                Console.WriteLine("The equasion has 2 real roots {0}, {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x1 = -b / 2 * a;

                Console.WriteLine("The equasion has 1 real root {0}", x1);
            }
            else
            {
                Console.WriteLine("The equasion has no real roots");
            }
        }
    }
}
