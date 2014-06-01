namespace Methods.Figures
{
    public struct Point
    {
        public Point(double x, double y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override string ToString()
        {
            string output = string.Format("{0}(x={1};y={2})", this.GetType().Name, this.X, this.Y);

            return output;
        }
    }
}
