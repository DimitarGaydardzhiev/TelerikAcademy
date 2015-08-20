using System;

namespace StaticClass
{
    public struct Point3D
    {
        //Fields

        private static readonly Point3D coordStart = new Point3D(0,0,0);

        //Properties
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }

        public static Point3D CoordStart
        {
            get
            {
                return (Point3D.coordStart);
            }
        }

        //Constructors
        public Point3D(decimal x, decimal y, decimal z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Methods
        public override string ToString()
        {
            string point3DAsString = string.Format("X coordinate = {0}\n X coordinate = {1}\n X coordinate = {2}\n"
                ,this.X,this.Y,this.Z);
            return point3DAsString;
        }
    }
}
