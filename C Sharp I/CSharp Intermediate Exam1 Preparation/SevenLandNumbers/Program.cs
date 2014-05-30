using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenLandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int powerNum = 0;
            int decimalNum = 0;

            while (input != 0)
            {
                int digit = input % 10;
                decimalNum += digit * (int)Math.Pow(7, powerNum);
                powerNum++;
                input /= 10;
            }


            decimalNum++;
            string sevenNum = "";
            while (decimalNum != 0)
            {
                int digit = decimalNum % 7;
                sevenNum = digit + sevenNum;
                decimalNum /= 7;
            }
            Console.WriteLine(sevenNum);
        }

    }
}