using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong decimalNum = ulong.Parse(Console.ReadLine());
            if (decimalNum == 0)
            {
                Console.WriteLine("A");
                return;
            }

            string[] kaspichanNumbers = new string[256];
            FillArrayWithKaspichanNumbers(kaspichanNumbers, 0);

            string result = string.Empty;

            while (decimalNum > 0)
            {
                result = kaspichanNumbers[decimalNum % 256] + result;
                decimalNum /= 256;
            }
            Console.WriteLine(result);
        }

        static void FillArrayWithKaspichanNumbers(string[] kaspichanNumbers, int counter)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                kaspichanNumbers[counter] = i.ToString();
                counter++;
            }
            for (char i = 'a'; i <= 'h'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    kaspichanNumbers[counter] = string.Concat(i.ToString(), j.ToString());
                    counter++;
                }
            }
            for (char i = 'A'; i <= 'V'; i++)
            {
                kaspichanNumbers[counter] = string.Concat("i", i.ToString());
                counter++;
            }
        }

    }
}
