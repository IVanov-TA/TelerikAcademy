namespace EuclidianSpace3D
{
    public struct Point3D
    {
        #region FIELDS

        private static readonly Point3D ZeroPoint = new Point3D();

        private double x;
        private double y;
        private double z;
        #endregion

        #region CONSTRUCTORS

        public Point3D(double pointX, double pointY, double pointZ)
            : this()
        {
            this.X = pointX;
            this.Y = pointY;
            this.Z = pointZ;
        }

        #endregion

        #region PROPERTIES

        public static Point3D ZeroPointValue
        {
            get
            {
                return ZeroPoint;
            }
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

        public double Z
        {
            get
            {
                return this.z;
            }

            set
            {
                this.z = value;
            }
        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.x, this.y, this.z);
        }

        #endregion
    }
}
