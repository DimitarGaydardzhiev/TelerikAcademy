namespace Abstraction
{
    using System;

    internal abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
