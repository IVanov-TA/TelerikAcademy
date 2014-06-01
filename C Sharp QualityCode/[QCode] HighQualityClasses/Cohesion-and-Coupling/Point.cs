namespace CohesionAndCoupling
{
    internal struct Point
    {
        private double x, y;

        public Point(double x, double y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public double X 
        { 
            get
            {
                return this.x;
            }

            set 
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }
    }
}
