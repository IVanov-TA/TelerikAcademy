using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            int vladoPlayerBeers = 0;
            int mitkodPlayerBeers = 0;

            for (int i = 0; i < rounds; i++)
            {
                string input = Console.ReadLine();
                input.TrimStart('0');

                int vladosBeers = 0;
                int mitkosBeers = 0;

                if (input.Length % 2 == 0)
                {
                    for (int v = 0; v < input.Length / 2; v++)
                    {
                        vladosBeers += input[v];
                    }
                    vladoPlayerBeers += vladosBeers;
                    for (int m = input.Length - 1; m > (input.Length / 2); m--)
                    {
                        mitkosBeers += input[m];
                    }
                    mitkodPlayerBeers += mitkosBeers;

                }
                else
                {
                    int oddBeerNumber = 0;

                    for (int v = 0; v < input.Length / 2; v++)
                    {
                        oddBeerNumber++;
                        vladosBeers += input[v];
                    }
                    vladosBeers += input[oddBeerNumber];
                    vladoPlayerBeers += vladosBeers;

                    for (int m = input.Length - 1; m > (input.Length / 2); m--)
                    {
                        mitkosBeers += input[m];
                    }
                    mitkodPlayerBeers += mitkosBeers;
                }

            }
        }
    }
}
