using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuranKulakNumbers
{
    class Program
    {
        static void Main()
        {
            string durankulanNum = Console.ReadLine().Trim(' ');

            string[] duranKulak = new string[168];
            int counter = 0;

            for (char i = 'A'; i <= 'Z'; i++)
            {
                duranKulak[counter] = i.ToString();
                counter++;
            }
            for (char i = 'a'; i <= 'e'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    duranKulak[counter] = string.Concat(i.ToString(), j.ToString());
                    counter++;
                }
            }

            for (char i = 'A'; i <= 'L'; i++)
            {
                duranKulak[counter] = string.Concat("f", i.ToString());
                counter++;
            }
            Console.WriteLine(ConvertFromDuranToDecimal(duranKulak, durankulanNum));
        }

        private static int GetNumericRepresentation(string[] alphabet, string durankulakNumber)
        {
            return Array.IndexOf(alphabet, durankulakNumber);
        }

        private static long ConvertFromDuranToDecimal(string[] alphabet, string durankulakNumber)
        {
            int currentDigit = 0;
            int power = 0;
            long result = 0;
            while (durankulakNumber.Length > 0)
            {
                if (durankulakNumber.Length > 1)
                {
                    currentDigit = GetNumericRepresentation(alphabet, durankulakNumber.Substring(durankulakNumber.Length - 2, 2));
                   durankulakNumber = durankulakNumber.Remove(durankulakNumber.Length - 2, 2);
                }
                else
                {
                    currentDigit = GetNumericRepresentation(alphabet, durankulakNumber.Substring(durankulakNumber.Length - 1, 1));
                    durankulakNumber = durankulakNumber.Remove(durankulakNumber.Length - 1, 1);
                }
                result += currentDigit * (long)Math.Pow(168, power);
                power++;
            }
            return result;
        }

        static void ReturnList(string durankulanNum) 
        {
            List<string> allData = new List<string>();

            for (int i = durankulanNum.Length - 2; i >= 0; i--)
            {
                if (char.IsLower(durankulanNum[i]))
                {
                    allData.Add(string.Concat(durankulanNum[i], durankulanNum[i+1]));
                }
                else
                {
                    //allData.Add()
                }
            }


        }
    }
}
