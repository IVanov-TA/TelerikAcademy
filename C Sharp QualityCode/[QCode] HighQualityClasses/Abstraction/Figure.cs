namespace Abstraction
{
    using System;

    public abstract class Figure 
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            string output = string.Format("{0} -> Perimeter: {1}, Surface: {2}", this.GetType().Name, this.CalcPerimeter(), this.CalcSurface());
            return output;
        }
    }
}
