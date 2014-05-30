namespace EuclidianSpace3D
{
    using System;

    public static class PointsDistance
    {
        public static double Calculate(Point3D point1, Point3D point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.X - point1.X;
            double deltaZ = point2.X - point1.X;
            return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
        }
    }
}
