
namespace Shapes
{
    using System;
    public class Square : Shape
    {
        public Square(double side)
        {
            this.Height = side;
            this.Width = side;
        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return String.Format("Square");
        }
    }
}
