namespace BooleanPrinter
{
    using System;

    public class StartingPoint
    {
        public const int MaxCount = 6;

        public static void Main()
        {
            BooleanAsTextPrinter printer = new BooleanAsTextPrinter();
            printer.PrintVariableAsText(true);
        }
    }
}