namespace CohesionAndCoupling
{
    using System;

   public class UtilsExamples
    {
       public static void Main()
        {
            Console.WriteLine(FileUtility.GetFileExtension("example"));
            Console.WriteLine(FileUtility.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.new.pdf"));

            Point point1 = new Point(1, -2);
            Point point2 = new Point(3, 4);
            Point point3 = new Point(-6, 4);

            Console.WriteLine("Distance in the 2D space = {0:f2}", GeometryUtility.CalcDistance2D(point1, point2));
            Console.WriteLine("Distance in the 3D space = {0:f2}", GeometryUtility.CalcDistance3D(point1, point2, point3));

            Figure3D figure = new Figure3D(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
