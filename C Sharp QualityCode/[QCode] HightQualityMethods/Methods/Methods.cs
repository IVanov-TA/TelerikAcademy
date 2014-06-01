namespace Methods
{
    using System;

    using Figures;
    using Students;
    using Utilities;

    public class Methods
    {
        public static void Main()
        {
            // Triangle class area test
            Triangle triangle = new Triangle(4, 5, 2);
            NumberUtility.PrintWithFixedPoint(FigureUtility.TriangleArea(triangle));

            // ArrayUtility class test
            int[] collectionOfInts = new int[] { 5, -1, 3, 2, 14, 2, 3 };
            Console.WriteLine(ArrayUtility.FindMax(collectionOfInts));

            // NumberUtility class test
            Console.WriteLine(NumberUtility.GetDigitName(5));
            NumberUtility.PrintWithFixedPoint(1.3);
            NumberUtility.PrintAsPercent(0.75);
            NumberUtility.PrintWithRightAlignment(2.30);

            // Point struc and FigureUtility class tests
            var pointOne = new Point(3, -1);
            var pointTwo = new Point(3, 2.5);

            var distanceBetweenTwoPoints = FigureUtility.CalculateDistanceBetweenTwoPoints(pointOne, pointTwo);
            Console.WriteLine("Distance between two points is: {0}", distanceBetweenTwoPoints);

            var areTwoPointsHorizontal = FigureUtility.AreTwoPointsHorizontal(pointOne, pointTwo);
            Console.WriteLine("Are two points horizontal: {0}", areTwoPointsHorizontal);

            var areTwoPointsVertical = FigureUtility.AreTwoPointsVertical(pointOne, pointTwo);
            Console.WriteLine("Are two points vertical: {0}\n", areTwoPointsVertical);

            // Student class test
            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 11, 3));
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
