namespace Utilities
{
    using System;

    public class GeometryUtilities
    {
        public static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should have positive values.");
            }

            if (((sideA + sideB) < sideC) || ((sideA + sideC) < sideB) || ((sideB + sideC) < sideA))
            {
                throw new ArgumentException("The three sides don't form a triangle.");
            }

            double perimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            return area;
        }

        public static void IsLineValid(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 || y1 == y2)
            {
                throw new ArgumentException("Line is invalid.");
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            IsLineValid(x1, y1, x2, y2);

            double xDifference = x2 - x1;
            double yDifference = y2 - y1;

            double distance = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));

            return distance;
        }

        public static bool IsHorizontalLine(double x1, double y1, double x2, double y2)
        {
            IsLineValid(x1, y1, x2, y2);

            bool result = y1 == y2;

            return result;
        }

        public static bool IsVerticallLine(double x1, double y1, double x2, double y2)
        {
            IsLineValid(x1, y1, x2, y2);

            bool result = x1 == x2;

            return result;
        }
    }
}
