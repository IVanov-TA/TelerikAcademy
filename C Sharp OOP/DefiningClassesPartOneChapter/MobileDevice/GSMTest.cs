namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is the GSM TestClass Task 7
    /// </summary>
    public class GSMTest
    {
        #region FIELDS

        // generate the private static  array instance of class GSM
        private static List<GSM> devices = new List<GSM> 
        { 
            new GSM("Samsung", "Samsung ", 100, "Mtel", new Battery(BatteryTypes.NiCd), new Display(10, 22000000)),
            new GSM("HTC", "Taiwan Electronics", 9.99m, "Globul", new Battery(BatteryTypes.LiPoly, "z45-09", 30, 25), new Display(10, 77000000)),
            new GSM("Huawei", "China Electronics", 300, "Private", new Battery(BatteryTypes.NiMH, "2I-O1", 40, 30), new Display(19, 100000000))
        };

        #endregion

        #region METHODS

        // generate public method to print the instance array above
        public static void PrintDevices()
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.ToString());
                Console.WriteLine();
            }
        }

        // print the static readonly field from the GSM class
        public static void PrintIPhone4s()
        {
            Console.WriteLine(GSM.IPhone4s);
        }

        #endregion
    }
}
