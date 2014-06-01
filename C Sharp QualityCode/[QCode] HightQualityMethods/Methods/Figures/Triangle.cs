namespace Methods.Figures
{
    using System;

    public class Triangle
    {
        private const string InvalidTriangleSideException = "Triangle side must not be <= 0 and yours is {0}";
        private const string InvalidTriangleException = "Can not create triangle with these sides";

        private double triangleSideA;
        private double triangleSideB;
        private double triangleSideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateTriangle(sideA, sideB, sideC);

            this.TriangleSideA = sideA;
            this.triangleSideB = sideB;
            this.TriangleSideC = sideC;
        }

        public double TriangleSideA
        {
            get
            {
                return this.triangleSideA;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(InvalidTriangleSideException, value));
                }

                this.triangleSideA = value;
            }
        }

        public double TriangleSideB
        {
            get
            {
                return this.triangleSideB;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(InvalidTriangleSideException, value));
                }

                this.triangleSideB = value;
            }
        }

        public double TriangleSideC
        {
            get
            {
                return this.triangleSideC;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(InvalidTriangleSideException, value));
                }

                this.triangleSideC = value;
            }
        }

        private static void ValidateTriangle(double sideA, double sideB, double sideC)
        {
            bool isValid = (sideA + sideB) > sideC &&
                           (sideA + sideC) > sideB &&
                           (sideB + sideC) > sideA;

            if (!isValid)
            {
                throw new ArgumentException(InvalidTriangleException);
            }
        }
    }
}
