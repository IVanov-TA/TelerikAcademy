namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// All exercises from homework (1 - 12) are included in this assembly.
    /// GOOD DAY.
    /// </summary>
   public class Program
    {
       public static void Main()
        {
            try
            {
                GSMCallHistoryTest.CallHistoryTest();

                // GSMTest.PrintDevices();
                // GSMTest.PrintIPhone4s();
            }
            catch (Exception em)
            {
                Console.WriteLine("Error: {0}", em.Message);
            }
        }
    }
}
