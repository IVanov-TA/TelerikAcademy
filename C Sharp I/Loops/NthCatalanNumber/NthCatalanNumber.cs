//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthCatalanNumber
{
    class NthCatalanNumber
    {
        static void Main(string[] args)
        {
            ulong NcataNum = ulong.Parse(Console.ReadLine());

            ulong factN = 1, factNPlus1 = 1;
            for (ulong i = 1; i <= NcataNum + 1; i++)
            {
                if (i <= NcataNum)
                {
                    factN *= i;
                }
                factNPlus1 *= i;
            }

            ulong doubleFactN = 1;
            for (ulong i = 1; i <= NcataNum * 2; i++)
            {
                doubleFactN *= i;
            }

            NcataNum = doubleFactN / (factNPlus1 * factN);

            Console.WriteLine(NcataNum);
        }
    }
}
