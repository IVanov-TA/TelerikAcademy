//(Task 3)Write an expression that calculates rectangle’s area by given width and height

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //values are type double because they can be with floating point and for more accuracy

            Console.Write("Please enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Please enter width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Area is: {0}", width * height); //print result
        }
    }
}
