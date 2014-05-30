namespace ShapeTask
{
    using System;
    using System.Collections.Generic;

    public class ShapeMain
    {
        public static void Main()
        {
            IEnumerable<Shape> calculatedSurfase = new List<Shape>()
            {
                new Triangle(30, 40),
                new Rectangle(20, 20),
                new Cirlce(5),
            };

            foreach (var figure in calculatedSurfase)
            {
                Console.WriteLine("{0} -> {1}", figure.GetType().Name, figure.CalculateSurface());
            }
        }
    }
}
