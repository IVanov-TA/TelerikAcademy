namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        #region FIELDS

        // declaring needed fields dateCall is the date, timeCall is time after the call and will be returned in minutes
        private DateTime dateCall;
        private DateTime timeCall;
        private string dialedPhoneNumber;

        #endregion

        #region CONSTRUCTOR

        // if we gonna have call then ALL the fields MUST be filled
        public Call(DateTime dateCall, DateTime timeCall, string phoneNumber)
        {
            this.DateCall = dateCall.ToString();
            this.TimeCall = timeCall.ToString();
            this.DialedPhoneNumber = phoneNumber;
        }

        #endregion

        #region PROPERTIES

        public string DateCall
        {
            // get the value of dateCall as shortdate format example(1.2.2014)
            get { return this.dateCall.ToShortDateString(); }
            /* setting the field dateCall with value with parsing to datetime
            we can use this parse for checking the value for correct value in future not now :)*/
            set { this.dateCall = DateTime.Parse(value); }
        }

        public string TimeCall
        {
            // same as above method
            get { return this.timeCall.ToShortTimeString(); }
            set { this.timeCall = DateTime.Parse(value); }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }

            set
            {
                // we expect at leats 10 digits for correct number. We can change that condition 
                if (value.Length < 10)
                {
                    throw new ArgumentException("Incorect phone number.");
                }

                this.dialedPhoneNumber = value;
            }
        }

        // this method returns the call duration in secs. Here I don't use field because I just want to get the value, not to set it.
        public double CallDuration
        {
            get { return (this.timeCall - this.dateCall).TotalSeconds; }
        }

        #endregion

        #region MTEHODS

        // create override ToString() method to get needed values in the format we want them
        public override string ToString()
        {
            StringBuilder callSB = new StringBuilder();
            callSB.AppendFormat("{0}\nDuration: {1} min. or / {2} sec /\nMade on: {3}", this.DialedPhoneNumber, this.TimeCall, this.CallDuration, this.DateCall);

            return callSB.ToString();
        }

        #endregion
    }
}