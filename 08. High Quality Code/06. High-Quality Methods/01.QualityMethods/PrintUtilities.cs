namespace Utilities
{
    using System;

    public class PrintUtilities
    {
        public static void PrintNumber(double number, int decimalPlaces)
        {
            string format = "{0:f" + decimalPlaces + "}";
            Console.WriteLine(format, number);
        }

        public static void PrintPercent(double number, int decimalPlaces)
        {
            string format = "{0:p" + decimalPlaces + "}";
            Console.WriteLine(format, number);
        }

        public static void PrintAlignedNumber(double number, int alignedPlaces)
        {
            string format = "{0:r" + alignedPlaces + "}";
            Console.WriteLine(format, number);
        }
    }
}
