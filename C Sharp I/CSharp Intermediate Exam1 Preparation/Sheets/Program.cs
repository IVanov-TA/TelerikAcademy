using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sheets = new int[11];
            int sum = 0;

            for (int i = 0; i < sheets.Length; i++)
            {
                int stepen = 1;
                for (int j = 0; j <= i; j++)
                {
                    stepen *= 2;
                }

                sheets[i] = stepen / 2;
                sum += sheets[i];
            }

            int N = int.Parse(Console.ReadLine());

            for (int i = sheets.Length-1; i >= 0; i--)
            {
                if (N < sheets[i])
                {
                    Console.WriteLine("A{0}", (10 - Array.IndexOf(sheets, sheets[i])));
                }
                else
                {
                    N = N % sheets[i];
                }

            }

        }
    }
}
