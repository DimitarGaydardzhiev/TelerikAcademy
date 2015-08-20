using System;

namespace CallHistory
{
    public class Calls
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private double duration;

        //Constructors

        public Calls(DateTime dateAndTime, string dialedPhoneNumber, double duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        //Properties

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(dialedPhoneNumber))
                {
                    throw new ArgumentException("Not a valid phone number!");
                }
                this.dialedPhoneNumber = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration should be more than 0 seconds!");
                }
                this.duration = value;
            }
        }
    }
}
