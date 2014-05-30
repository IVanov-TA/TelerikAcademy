using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int PX1 = int.Parse(Console.ReadLine());
            int PY1 = int.Parse(Console.ReadLine());
            int PX2 = int.Parse(Console.ReadLine());
            int PY2 = int.Parse(Console.ReadLine());

            int FX1 = int.Parse(Console.ReadLine());
            int FY1 = int.Parse(Console.ReadLine());

            int D = int.Parse(Console.ReadLine());

            int result = 0;

            int maxX = Math.Max(PX1, PX2);
            int minX = Math.Min(PX1, PX2);
            int maxY = Math.Max(PY1, PY2);
            int minY = Math.Min(PY1, PY2);

            int hitted = D + FX1;

            //solution

            if ((hitted >= minX) && (hitted <= maxX) && (FY1 >= minY && FY1 <= maxY))
            {
                result += 100;
                    
            }

            int leftCell = FY1 + 1;
            int rightCell = FY1 - 1;
            int nextCell = hitted + 1;

            if (leftCell <= maxY && (hitted >= minX && hitted <= maxX))
            {
                result += 50;
            }
            if ((rightCell >= minY) && (hitted >= minX && hitted <= maxX))
            {
                result += 50;
            }
            if (nextCell <= maxX && nextCell >= minX)
            {
                result += 75;
            }

            //output
            Console.WriteLine("{0}%", result);

        }
    }
}
