namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private const string CirlceRadiusException = "Cyrcle radius must be > 0";

        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(CirlceRadiusException);
                }

                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("{0}, Radius: {1}", base.ToString(), this.Radius);
        }
    }
}
