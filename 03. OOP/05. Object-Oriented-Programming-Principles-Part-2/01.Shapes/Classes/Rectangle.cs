
namespace Shapes
{
    using System;
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return String.Format("Rectangle");
        }
    }
}
