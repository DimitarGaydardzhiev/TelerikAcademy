
namespace RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException
    {
        //Fields
        private T startRange;
        private T endRange;

        //Properties

        public T StartRagne
        {
            get
            {
                return this.startRange;
            }
            set
            {
                this.startRange = value;
            }
        }
        public T EndRange
        {
            get
            {
                return this.endRange;
            }
            set
            {
                this.endRange = value;
            }
        }

        //Constructor

        public InvalidRangeException(string msg, T startRange, T endRange)
            :base(msg)
        {
            this.StartRagne = startRange;
            this.EndRange = endRange;
        }
    }
}
