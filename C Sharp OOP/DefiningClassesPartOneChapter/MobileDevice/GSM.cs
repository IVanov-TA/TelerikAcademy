namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is the Main Class from the homework
    /// all tasks are included.
    /// </summary>
    public class GSM
    {
        #region CONSTANTS

        // price const
        private const double PricePerMinute = 0.37;

        #endregion

        #region FIELDS

        // static readonly GSM instance
        private static readonly GSM StaticIPhone4S = new GSM("4S", "Apple", 300, "Me", new Battery(BatteryTypes.LiPoly, "IS-025", 35m, 20m), new Display(20, 64000000));

        // innitiating needed fields, instance of classes and Lists
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();
        private List<Call> callList;

        #endregion

        #region  CONSTRUCTORS

        // 4 constructors we need atleast 2 values fild(model, manufacturer) when creating instance
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
            this.callList = new List<Call>();
        }

        #endregion

        #region PROPERTIES

        public static GSM IPhone4s
        {
            get { return StaticIPhone4S; }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model name not specified");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer is not specified. (null/empty)");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative value.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.owner = "unknow owner";
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callList;
            }
        }

        #endregion

        #region METHODS
        
        // all need methods
        public void AddCall(DateTime dateCall, DateTime timeCall, string phoneNumber)
        {
            this.callList.Add(new Call(dateCall, timeCall, phoneNumber));
        }

        public void DeleteCall(int selectedCall)
        {
            if ((selectedCall >= 0) || (selectedCall < this.callList.Count))
            {
                this.callList.RemoveAt(selectedCall);
            }
            else
            {
                throw new ArgumentException("Record not found.");
            }
        }

        public void ClearCallList()
        {
            this.callList.Clear();
        }

        public void DeleteLongestCall() 
        {
            double longestCall = double.MinValue;
            Call deleteItem = null;

            foreach (var item in this.callList)
            {
                if (longestCall < item.CallDuration)
                {
                    longestCall = item.CallDuration;
                    deleteItem = item;
                }
            }

            // return the index of the longestCall from callList to the DeleteCall Method
            this.DeleteCall(this.callList.IndexOf(deleteItem));
        }

        public double GetTotalAmount()
        {
            double totalCallTime = 0;
            foreach (var call in this.callList)
            {
                totalCallTime += call.CallDuration;
            }

            double totalAmount = (totalCallTime / 60) * PricePerMinute;
            return totalAmount;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Model: {0}\nManufacturer: {1}\nPrice: ${2:0.00}\nOwner: {3}\nBattery: {4}\n{5}Model: {12}\n{13}HoursIdle: {6}\n{7}HourseTalk: {8}\nDisplay: Inches: {9}\n{10}Colors: {11}", this.model, this.manufacturer, this.price, this.owner, this.battery.BatteryType, string.Empty.PadLeft(9, ' '), this.battery.HoursIdle, string.Empty.PadLeft(9, ' '), this.battery.HoursTalk, this.display.Size, string.Empty.PadLeft(9, ' '), this.display.Colors, this.battery.Model, string.Empty.PadLeft(9, ' ')));
            info.AppendLine(new string('-', 30));

            if (this.callList.Count != 0)
            {
                for (int i = 0; i < this.callList.Count; i++)
                {
                    info.AppendLine("Call #" + (i + 1) + "\n" + this.callList[i]);
                    info.AppendLine(new string('-', 30));
                }
            }
            else
            {
                info.AppendLine("No record calls found.");
                info.AppendLine(new string('-', 30));
            }

            return info.ToString();
        }

        #endregion
    }
}
