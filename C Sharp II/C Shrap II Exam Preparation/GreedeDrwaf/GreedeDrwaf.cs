using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedeDrwaf
{
    class GreedeDrwaf
    {
        static void Main()
        {
            string[] rawData = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string[] valey = (string[])rawData.Clone();

            int paterns = int.Parse(Console.ReadLine());
            long bestSum = long.MinValue;

            for (int i = 0; i < paterns; i++)
            {
                long coins = ProcessTheCurrentPattern(valey);

                if (bestSum < coins)
                {
                    bestSum = coins;
                }
            }
            Console.WriteLine(bestSum);
        }

        private static long ProcessTheCurrentPattern(string[] valey)
        {
            string[] patern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            long totalCoins = 0;
            int currentPosition = 0;

            bool[] isVisited = new bool[valey.Length];

            totalCoins = int.Parse(valey[currentPosition]);
            isVisited[currentPosition] = true;

            while (true)
            {
                for (int i = 0; i < patern.Length; i++)
                {
                    int nextPosition = currentPosition + int.Parse(patern[i]);

                    if (nextPosition < valey.Length && nextPosition >= 0 && !isVisited[nextPosition])
                    {
                        totalCoins += int.Parse(valey[nextPosition]);
                        isVisited[nextPosition] = true;
                        currentPosition = nextPosition;
                    }
                    else
                    {
                        return totalCoins;
                    }
                }
            }
        }
    }
}
