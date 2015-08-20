namespace BooleanPrinter
{
    using System;

    public class BooleanAsTextPrinter
    {
        public void PrintVariableAsText(bool value)
        {
            string result = value.ToString();
            Console.WriteLine(result);
        }
    }
}