namespace EuclidianSpace3D
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        #region FIELDS

        private List<Point3D> path;

        #endregion

        #region CONSTRUCTOR

        public Path()
        {
            this.path = new List<Point3D>();
        }

        #endregion

        #region METHODS

        public void AddPoint()
        {
            this.path.Add(Point3D.ZeroPointValue);
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }

        public void AddPoint(double x, double y, double z)
        {
            this.path.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            StringBuilder pathToStr = new StringBuilder();
            for (int i = 0; i < this.path.Count; i++)
            {
                pathToStr.AppendFormat("Point {0}: ", i + 1).Append(this.path[i]);

                if (i + 1 < this.path.Count)
                {
                    pathToStr.AppendLine();
                }
            }

            return pathToStr.ToString();
        }

        #endregion
    }
}
