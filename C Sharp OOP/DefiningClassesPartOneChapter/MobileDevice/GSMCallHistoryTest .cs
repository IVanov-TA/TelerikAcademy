namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {
        #region METHOD

        /* static method to check GSM and call history
         * create instance of GSM class and add calls 
         * after that check all method from GSM class connected with Call class
         * (DeleteLongestCall, GetTotalAmount etc.)
         */
        public static void CallHistoryTest()
        {
            GSM testDevice = new GSM("Galxy", "Samsung ", 100, "SomeTel", new Battery(BatteryTypes.LiPoly), new Display(10, 22000000));
            testDevice.AddCall(DateTime.Today, DateTime.Today.AddMinutes(11), "0899999888");
            testDevice.AddCall(DateTime.Today, DateTime.Today.AddMinutes(21), "0877799888");
            testDevice.AddCall(DateTime.Today, DateTime.Today.AddMinutes(31), "0896666668");
            testDevice.AddCall(DateTime.Today, DateTime.Today.AddMinutes(41), "0892526278");
            testDevice.AddCall(DateTime.Today, DateTime.Today.AddMinutes(51), "0883567288");

            Console.WriteLine("Info for Phone and call List:\n");
            Console.WriteLine(testDevice.ToString());
            Console.WriteLine("Total Amount is: $ {0}", testDevice.GetTotalAmount());
            testDevice.DeleteLongestCall();
            Console.WriteLine("\nAfter Deleting the longest call:\n");
            Console.WriteLine(testDevice.ToString());
            Console.WriteLine("Total Amount after deleting the call is: $ {0}", testDevice.GetTotalAmount());
            Console.WriteLine("\nAfter cleaning the call history:\n");
            testDevice.ClearCallList();
            Console.WriteLine(testDevice.ToString());
            Console.WriteLine("Total Amount is: $ {0}", testDevice.GetTotalAmount());
        }

        #endregion
    }
}
