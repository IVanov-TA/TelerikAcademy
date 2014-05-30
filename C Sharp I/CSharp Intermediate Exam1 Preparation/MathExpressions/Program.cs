using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MathExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double nominator = (N * N) + 1 / (M * P) + 1337;
            double denominator = N - 128.523123123 * P;
            int epr = (int)(M) % 180;
            double addtional = Math.Sin(epr);

            double expression = (nominator / denominator) + addtional;
            Console.WriteLine("{0:F6}", expression);
        }
    }
}
