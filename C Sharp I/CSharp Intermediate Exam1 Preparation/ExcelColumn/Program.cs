using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            double result = 0;
            int p = inputN - 1;
            for (int i = 0; i < inputN; i++)
            {
                int character = char.Parse(Console.ReadLine());

                result += (character - 64) * (int)Math.Pow(26, p);
                p--;

            }
            Console.WriteLine(result);
        }
    }
}
