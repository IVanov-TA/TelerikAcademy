namespace ShapeTask
{
    using System;

    public class Rectangle : Shape, IShape
    {
        public Rectangle(double rectWidth, double rectHeight)
            : base(rectWidth, rectHeight)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
