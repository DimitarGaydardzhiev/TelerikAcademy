
namespace CallPrice
{
    using System;
    public class Display
    {
        //Fields
        private double? size;
        private int? numberOfColors;

        //Properties
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display size should be a positive number!");
                }
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors should be a positive number!");
                }
                this.numberOfColors = value;
            }
        }

        public Display(double? size = null, int? numberOfColors = null)
        {
            //The constructor is calling the property, not the field, to perform a data validation through the property nand the field
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}
