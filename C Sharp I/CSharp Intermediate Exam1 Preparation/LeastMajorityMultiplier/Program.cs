using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastMajorityMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int counter = 0;
            int divider = 1;

            while (true)
            {
                if (divider % a == 0)
                {
                    counter++;
                }
                if (divider % b == 0)
                {
                    counter++;
                }
                if (divider % c == 0)
                {
                    counter++;
                }
                if (divider % d == 0)
                {
                    counter++;
                }
                if (divider % e == 0)
                {
                    counter++;
                }
                if (counter >= 3)
                {
                    Console.WriteLine(divider);
                    break;
                }
                divider++;
                counter = 0;
            }
        }
    }
}
