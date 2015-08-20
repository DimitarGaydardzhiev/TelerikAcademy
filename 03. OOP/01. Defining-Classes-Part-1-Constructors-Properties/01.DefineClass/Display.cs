
namespace _01.DefineClass
{
    using System;
    public class Display
    {
        //Fields
        private double size;
        private int numberOfColors;

        //Properties
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }
    }
}
