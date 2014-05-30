namespace EuclidianSpace3D
{
    using System;

    public class EuclidianSpace3D
    {
        public static void Main()
        {
            Point3D newPoint = new Point3D(2, 5, 8);
            Console.WriteLine("Instance of Point3D class: {0}", newPoint);
            Console.WriteLine("Zero static readonly point from Point3D class: {0}", Point3D.ZeroPointValue);
            Console.WriteLine("Distance is: {0}", PointsDistance.Calculate(newPoint, Point3D.ZeroPointValue));

            Path newPath = new Path();
            newPath.AddPoint(newPoint);
            newPath.AddPoint();
            newPath.AddPoint(11, 12, 13);
            Console.WriteLine("Path Items Printed:\n{0}\n", newPath);
            Console.WriteLine("Saving the path to file...\n");

            // saving data
            PathStorage.SaveData(newPath);

            Console.WriteLine("After Loading the data.\n");

            // loading data
            Path p = PathStorage.LoadData();
            Console.WriteLine(p);
        }
    }
}
