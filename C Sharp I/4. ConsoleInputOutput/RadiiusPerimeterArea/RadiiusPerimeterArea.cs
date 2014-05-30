//Write a program that reads the radius r of a circle and prints its perimeter and area.


using System;

namespace RadiiusPerimeterArea
{
    class Program
    {
        static void Main()
        {
            int radius;
            Console.Write("Enter radius of a cyrcle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perimeter of the radius is {0} and it's area is {1}", 2 * Math.PI * radius, Math.PI * radius * radius);
        }
    }
}
