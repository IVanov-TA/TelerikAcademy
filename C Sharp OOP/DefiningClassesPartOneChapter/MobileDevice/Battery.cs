namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // creating the enum type from task 3
    public enum BatteryTypes
    {
        None, LiPoly, Lilon, NiMH, NiCd
    }

    public class Battery
    {
        #region FIELDS

        // initialize all needed fields
        private string model;
        private decimal hoursIdle;
        private decimal hoursTalk;
        private BatteryTypes batteryType;

        #endregion

        #region CONSTRUCTORS
        
        // create 3 types of constructors [NO PARAMETER], [1 PAR -> BATTERY TYPE], [ALL PARAMETERS]
        public Battery()
        {
        }

        public Battery(BatteryTypes batteryType)
            : this(batteryType, null, 0m, 0m)
        {
        }

        public Battery(BatteryTypes batteryType, string model, decimal hoursIdle, decimal hoursTalk)
        {
            this.BatteryType = batteryType;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        #endregion

        #region PROPERTIES

        public string Model
        {
            get 
            { 
                return this.model;
            }

            set
            {
                // setting the this.model field with value = unknown if the value is empty/null 
                if (string.IsNullOrEmpty(value))
                {
                    this.model = "unknown";
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public decimal HoursIdle
        {
            get 
            { 
                return this.hoursIdle; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle can't be negative value");
                }

                this.hoursIdle = value;
            }
        }

        public decimal HoursTalk
        {
            get 
            {
                return this.hoursTalk; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HoursTalk can't be negative value.");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryTypes BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        #endregion
    }
}
