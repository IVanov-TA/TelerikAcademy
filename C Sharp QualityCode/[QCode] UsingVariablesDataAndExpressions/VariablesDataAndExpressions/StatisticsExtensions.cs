using System;
using System.Linq;

namespace VariablesDataAndExpressions
{
    public class StatisticsExtensions
    {
        public void PrintStatistics(double[] currentArray)
        {
            Console.WriteLine(FindMaxValue(currentArray));
            Console.WriteLine(FindMinValue(currentArray));
            Console.WriteLine(FindAverageValue(currentArray));
        }

        private static double FindAverageValue(double[] currentArray)
        {
            double sumOfElements = 0;
            for (int i = 0; i < currentArray.Length; i++)
            {
                sumOfElements += currentArray[i];
            }

            return sumOfElements / currentArray.Length;
        }

        private static double FindMinValue(double[] currentArray)
        {
            double minValue = 0;
            for (int i = 0; i < currentArray.Length; i++)
            {
                if (currentArray[i] < minValue)
                {
                    minValue = currentArray[i];
                }
            }

            return minValue;
        }

        private static double FindMaxValue(double[] currentArray)
        {
            double max = 0;
            for (int i = 0; i < currentArray.Length; i++)
            {
                if (currentArray[i] > max)
                {
                    max = currentArray[i];
                }
            }

            return max;
        }
    }
}