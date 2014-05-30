using System;
using System.Linq;

namespace VariablesDataAndExpressions
{
    public static class FigureExtensions
    {
        public static Figure GetRotatedSize(
            Figure currentFigure, double rotationAngle)
        {
            var cosAngleRotation = Math.Abs(Math.Cos(rotationAngle));
            var sinAngleRotation = Math.Abs(Math.Sin(rotationAngle));

            var rotatedWidth = (cosAngleRotation * currentFigure.Width) + (sinAngleRotation * currentFigure.Height);
            var rotatedHeight = (sinAngleRotation * currentFigure.Width) + (cosAngleRotation * currentFigure.Height);

            return new Figure(rotatedWidth,rotatedHeight);                                                                             
        }
    }
}
