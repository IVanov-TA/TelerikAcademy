using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal[] arrayValues = new decimal[N];
            for (int i = 0; i < N; i++)
            {
                arrayValues[i] = decimal.Parse(Console.ReadLine());
            }

            var tmpCounter = arrayValues.GroupBy(v => v); //getting key and value   
            foreach (var group in tmpCounter)
            {
                if (group.Count() % 2 != 0) // getting group count
                {
                    Console.WriteLine(group.Key);
                }
            }
        }
    }
}
