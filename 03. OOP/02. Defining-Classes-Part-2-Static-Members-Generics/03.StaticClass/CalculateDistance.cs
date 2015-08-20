using System;

namespace StaticClass
{
    public static class CalculateDistance
    {
        private static Point3D firstPoint;
        private static Point3D secondPoint;

        public static Point3D FirstPoint
        {
            get
            {
                return CalculateDistance.firstPoint;
            }
            set
            {
                CalculateDistance.firstPoint = value;
            }
        }

        public static Point3D SecondPoint
        {
            get
            {
                return CalculateDistance.secondPoint;
            }
            set
            {
                CalculateDistance.secondPoint = value;
            }
        }

        public static double GetDistance(Point3D firstPoint, Point3D secondPoint)
        {
            decimal diffX = (firstPoint.X - secondPoint.X) * (FirstPoint.X - secondPoint.X);
            decimal diffY = (firstPoint.Y - secondPoint.Y) * (FirstPoint.Y - secondPoint.Y);
            decimal diffZ = (firstPoint.Z - secondPoint.Z) * (FirstPoint.Z - secondPoint.Z);

            double result = Math.Sqrt((double)(diffX + diffY + diffZ));

            return result;
        }
    }
}
