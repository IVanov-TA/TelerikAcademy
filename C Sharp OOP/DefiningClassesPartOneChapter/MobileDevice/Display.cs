namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        #region FIELDS

        // initializing the fields
        private decimal size;
        private uint colors;

        #endregion

        #region CONSTRUCTORS

        // using two constructors firts one is empty but add default values to the fields, second one get custom values  
        public Display()
            : this(0m, 2)
        {
        }

        public Display(decimal size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        #endregion

        #region PROPERTIES

        public decimal Size
        {
            get
            {
                return this.size;
            }

            set
            {
                // expected size is non negative
                if (value < 0)
                {
                    throw new ArgumentException("Size can't be negative value");
                }

                this.size = value;
            }
        }

        public uint Colors
        {
            get
            {
                return this.colors;
            }

            set
            {
                // we expect mobile phone with atleats 2 colors
                if (value < 2)
                {
                    // exeption is throwen when custom value is below 2 
                    throw new ArgumentException("Colors can't be less than 2");
                }

                this.colors = value;
            }
        }

        #endregion
    }
}
