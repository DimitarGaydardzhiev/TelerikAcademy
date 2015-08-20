namespace QualityMethods
{
    using System;
    using Person;
    using Utilities;

    public class StartingPoint
    {
        public static void Main()
        {
            Console.WriteLine(GeometryUtilities.CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(ArithmeticUtilities.NumberToDigit(5));

            Console.WriteLine(ArithmeticUtilities.FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintUtilities.PrintNumber(1.3, 1);
            PrintUtilities.PrintPercent(0.75, 0);
            PrintUtilities.PrintAlignedNumber(2.30, 8);

            Console.WriteLine(GeometryUtilities.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + GeometryUtilities.IsHorizontalLine(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + GeometryUtilities.IsVerticallLine(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));

            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1993, 11, 3));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
