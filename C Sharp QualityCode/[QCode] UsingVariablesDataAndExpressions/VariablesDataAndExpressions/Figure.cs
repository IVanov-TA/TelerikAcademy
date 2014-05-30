using System;
using System.Linq;

namespace VariablesDataAndExpressions
{
    public class Figure
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be a positive number");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be a positive number");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}