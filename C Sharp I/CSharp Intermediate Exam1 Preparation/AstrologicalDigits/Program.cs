using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string N = Console.ReadLine();
            N = N.TrimStart('-', ' ');
           
            BigInteger result = 0;
           

            //solution
            while (true)
            {
                for (int i = 0; i < N.Length; i++)
                {
                    BigInteger currentDigit = 0;
                    if (N[i] == '.' || N[i] == '-')
                    {
                        continue;
                    }
                    currentDigit = int.Parse(N[i].ToString());
                    result += currentDigit;
                }
                if (result > 9)
                {
                    N = result.ToString();
                    result = 0;
                }
                else
                {
                    break;
                }
                
            }
            


            //output
            Console.WriteLine(result);
        }
    }
}
