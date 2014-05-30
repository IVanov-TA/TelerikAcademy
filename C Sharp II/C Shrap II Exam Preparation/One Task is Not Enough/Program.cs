using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Task_is_Not_Enough
{
    class Program
    {
        static void Main()
        {
            int numberOfLamps = int.Parse(Console.ReadLine());

            List<int> lamps = new List<int>(numberOfLamps + 1);
            for (int i = 1; i <= numberOfLamps; i++)
            {
                lamps.Add(i);
            }
            GetLastTurnedOnLamp(lamps);
        }

        private static void GetLastTurnedOnLamp(List<int> lamps)
        {

            int step = 2;

            while (lamps.Count > 0)
            {
                for (int i = 1; i < lamps.Count; i += step)
                {
                    lamps.Remove(i);
                }
                step++;
                if (lamps.Count == 1)
                {
                    Console.WriteLine(lamps[0]);
                }
            }

        }
    }
}
