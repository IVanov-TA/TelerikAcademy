using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {

        static void Main(string[] args)
        {
            int juryN = int.Parse(Console.ReadLine());

            int cat1 = 0;
            int cat2 = 0;
            int cat3 = 0;
            int cat4 = 0;
            int cat5 = 0;
            int cat6 = 0;
            int cat7 = 0;
            int cat8 = 0;
            int cat9 = 0;
            int cat10 = 0;

            int selectedCat;

            for (int i = 0; i < juryN; i++)
            {
                selectedCat = int.Parse(Console.ReadLine());

                switch (selectedCat)
                {
                    case 1:
                        cat1++;
                        break;
                    case 2:
                        cat2++;
                        break;
                    case 3:
                        cat3++;
                        break;
                    case 4:
                        cat4++;
                        break;
                    case 5:
                        cat5++;
                        break;
                    case 6:
                        cat6++;
                        break;
                    case 7:
                        cat7++;
                        break;
                    case 8:
                        cat8++;
                        break;
                    case 9:
                        cat9++;
                        break;
                    case 10:
                        cat10++;
                        break;
                    default:
                        break;
                }
            }

            int maxVal = 0;
            int winner = 0;

            if (cat1 > maxVal)
            {
                maxVal = cat1;
                winner = 1;
            }
            if (cat2 > maxVal)
            {
                maxVal = cat2;
                winner = 2;
            }
            if (cat3 > maxVal)
            {
                maxVal = cat3;
                winner = 3;
            }
            if (cat4 > maxVal)
            {
                maxVal = cat4;
                winner = 4;
            }
            if (cat5 > maxVal)
            {
                maxVal = cat5;
                winner = 5;
            }
            if (cat6 > maxVal)
            {
                maxVal = cat6;
                winner = 6;
            }
            if (cat7 > maxVal)
            {
                maxVal = cat7;
                winner = 7;
            }
            if (cat8 > maxVal)
            {
                maxVal = cat8;
                winner = 8;
            }
            if (cat9 > maxVal)
            {
                maxVal = cat9;
                winner = 9;
            }
            if (cat10 > maxVal)
            {
                maxVal = cat10;
                winner = 10;
            }
            Console.WriteLine(winner);
        }
    }
}
