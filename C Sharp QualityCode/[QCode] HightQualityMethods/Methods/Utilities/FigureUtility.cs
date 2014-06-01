namespace Methods.Utilities
{
    using System;

    using Figures;

    public static class FigureUtility
    {
        public static double CalculateDistanceBetweenTwoPoints(Point p1, Point p2)
        {
            double distance = Math.Sqrt(((p2.X - p1.X) * (p2.X - p1.X)) + ((p2.Y - p1.Y) * (p2.Y - p1.Y)));
            return distance;
        }

        public static bool AreTwoPointsHorizontal(Point p1, Point p2)
        {
            bool areTwoPointsHorizontal = p1.Y == p2.Y;
            return areTwoPointsHorizontal;
        }

        public static bool AreTwoPointsVertical(Point p1, Point p2)
        {
            bool areTwoPointsVertical = p1.X == p2.X;
            return areTwoPointsVertical;
        }

        public static double TriangleArea(Triangle triangle) 
        {
            double perimeterHalf = (triangle.TriangleSideA + triangle.TriangleSideB + triangle.TriangleSideC) / 2;

            double area = Math.Sqrt(perimeterHalf * (perimeterHalf - triangle.TriangleSideA) *
                                                    (perimeterHalf - triangle.TriangleSideB) *
                                                    (perimeterHalf - triangle.TriangleSideC));

            return area;
        }
    }
}
