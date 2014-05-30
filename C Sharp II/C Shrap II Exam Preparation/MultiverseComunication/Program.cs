using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Multiverse_Communication
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine().ToUpper();
            int power = GetPower(msg);
            BigInteger result = ConvertFrom13thToDec(msg, power);
            Console.WriteLine(result);

        }

        static BigInteger ConvertFrom13thToDec(string msg, int power)
        {
            BigInteger decResult = 0;

            for (int i = 0; i < msg.Length; i += 3, power--)
            {
                int part = GetDecRepresentataion(msg.Substring(i, 3));
                decResult += part * (BigInteger)Math.Pow(13, power);
            }

            return decResult;
        }

        static int GetDecRepresentataion(string part)
        {
            int res = int.MinValue;
            switch (part)
            {
                case "CHU": res = 0; break;
                case "TEL": res = 1; break;
                case "OFT": res = 2; break;
                case "IVA": res = 3; break;
                case "EMY": res = 4; break;
                case "VNB": res = 5; break;
                case "POQ": res = 6; break;
                case "ERI": res = 7; break;
                case "CAD": res = 8; break;
                case "K-A": res = 9; break;
                case "IIA": res = 10; break;
                case "YLO": res = 11; break;
                case "PLA": res = 12; break;
                default: res = 0; break;
            }
            return res;
        }

        static int GetPower(string msg)
        {
            int power = (msg.Length / 3) - 1;
            return power;
        }

    }
}
