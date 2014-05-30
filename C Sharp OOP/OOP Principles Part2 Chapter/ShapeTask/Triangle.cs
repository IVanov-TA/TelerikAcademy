namespace ShapeTask
{
    using System;

    public class Triangle : Shape, IShape
    {
        public Triangle(double triangleWidth, double triangleHeight)
            : base(triangleWidth, triangleHeight)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
