using System;

namespace Structure
{
    struct Point3D
    {
        //Properties
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }

        //Constructors

        public Point3D(decimal x, decimal y, decimal z)
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
