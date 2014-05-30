namespace ShapeTask
{
    using System;

    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        public Shape(double shapeWidth, double shapeHeight)
        {
            this.Width = shapeWidth;
            this.Height = shapeHeight;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Value must be positive number > 0");
                }

                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Value must be positive number > 0");
                }

                this.height = value;
            }
        }

        #region IShape Members

        public abstract double CalculateSurface();

        #endregion
    }
}
