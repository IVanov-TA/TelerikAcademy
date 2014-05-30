using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int? number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    number *= -1;
                }

                string result = number.ToString();

                for (int i = 0; i < 3; i++)
                {
                    number = int.Parse(result);
                    int? lastDigit = number % 10;
                    number /= 10;
                    if (number == 0)
                    {
                        number = null;
                    }
                    if (lastDigit != 0)
                    {
                        if (number != null)
                        {
                            result = lastDigit.ToString() + number.ToString();
                        }
                        else
                        {
                            result = lastDigit.ToString();
                        }

                    }
                    else
                    {
                        result = number.ToString();
                    }
                }
                Console.WriteLine(result);

            }
        }
    }
}
