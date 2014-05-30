namespace ShapeTask
{
    using System;

    public class Cirlce : Shape, IShape
    {
        public Cirlce(double r)
            : base(r, r)
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width * this.Height);
        }
    }
}
