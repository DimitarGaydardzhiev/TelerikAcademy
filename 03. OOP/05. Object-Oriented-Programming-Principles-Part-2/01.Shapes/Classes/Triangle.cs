
namespace Shapes
{
    using System;
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }

        public override string ToString()
        {
            return String.Format("Triangle");
        }
    }
}
