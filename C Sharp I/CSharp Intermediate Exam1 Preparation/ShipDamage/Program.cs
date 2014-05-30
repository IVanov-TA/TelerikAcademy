using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int SX1 = int.Parse(Console.ReadLine());
            int SY1 = int.Parse(Console.ReadLine());

            int SX2 = int.Parse(Console.ReadLine());
            int SY2 = int.Parse(Console.ReadLine());

            int maxX = Math.Max(SX1, SX2);
            int minX = Math.Min(SX1, SX2);
            int maxY = Math.Max(SY1, SY2);
            int minY = Math.Min(SY1, SY2);

            int H = int.Parse(Console.ReadLine());

            int CX1 = int.Parse(Console.ReadLine());
            int CY1 = int.Parse(Console.ReadLine());
            CY1 = (2 * H) - CY1;

            int CX2 = int.Parse(Console.ReadLine());
            int CY2 = int.Parse(Console.ReadLine());
            CY2 = (2 * H) - CY2;

            int CX3 = int.Parse(Console.ReadLine());
            int CY3 = int.Parse(Console.ReadLine());
            CY3 = (2 * H) - CY3;

            int shipDamage = 0;

            if ((CX1 == maxX || CX1 == minX) && (CY1 == maxY || CY1 == minY))
            {
                shipDamage += 25;
            }
            if ((CX1 < maxX && CX1 > minX) && (CY1 < maxY && CY1 > minY))
            {
                shipDamage += 100;
            }
            if (((CX1 == maxX || CX1 == minX) && (CY1 < maxY && CY1 > minY)) || ((CY1 == maxY || CY1 == minY) && (CX1 < maxX && CX1 > minX)))
            {
                shipDamage += 50;
            }


            if ((CX2 == maxX || CX2 == minX) && (CY2 == maxY || CY2 == minY))
            {
                shipDamage += 25;
            }
            if ((CX2 < maxX && CX2 > minX) && (CY2 < maxY && CY2 > minY))
            {
                shipDamage += 100;
            }
            if (((CX2 == maxX || CX2 == minX) && (CY2 < maxY && CY2 > minY)) || ((CY2 == maxY || CY2 == minY) && (CX2 < maxX && CX2 > minX)))
            {
                shipDamage += 50;
            }


            if ((CX3 == maxX || CX3 == minX) && (CY3 == maxY || CY3 == minY))
            {
                shipDamage += 25;
            }
            if ((CX3 < maxX && CX3 > minX) && (CY3 < maxY && CY3 > minY))
            {
                shipDamage += 100;
            }
            if (((CX3 == maxX || CX3 == minX) && (CY3 < maxY && CY3 > minY)) || ((CY3 == maxY || CY3 == minY) && (CX3 < maxX && CX3 > minX)))
            {
                shipDamage += 50;
            }

            Console.WriteLine("{0}%", shipDamage);
        }
    }
}
