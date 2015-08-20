namespace ClassSize
{
    using System;

    public class Size
    {
        private double width, height;
 
        public Size(double initialWidth, double initialHeight)
        {
            this.width = initialWidth;
            this.height = initialHeight;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size figure, double angle)
        {
            double sinOfTheAngle = Math.Abs(Math.Sin(angle));
            double cosOfTheAngle = Math.Abs(Math.Sin(angle));

            double newWidth = (cosOfTheAngle * figure.width) + (sinOfTheAngle * figure.height);
            double newHeight = (sinOfTheAngle * figure.width) + (cosOfTheAngle * figure.height);

            return new Size(newWidth, newHeight);
        }
    }
}
