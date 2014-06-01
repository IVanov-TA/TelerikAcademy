namespace CohesionAndCoupling
{
    using System;

    internal static class GeometryUtility
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static double CalcDistance2D(Point point1, Point point2)
        {
            double distance = CalcDistance2D(point1.X, point1.Y, point2.X, point2.Y);
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        public static double CalcDistance3D(Point point1, Point point2, Point point3)
        {
            double distance = CalcDistance3D(point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y);
            return distance;
        }
    }
}
