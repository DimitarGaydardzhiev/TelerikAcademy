namespace MathProblem
{
    using System;
    using System.Collections.Generic;
    using Utilities;

    public class StartingPoint
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            sum = Calculator.SumInDecimalSystem(inputAsArray);

            var codes = Calculator.CalculateCodesIn19BasedSystem(sum);
            codes.Reverse();

            for (int i = 0; i < codes.Count; i++)
            {
                Console.Write((char)(codes[i] + 97));
            }

            Console.Write(" " + "=" + " ");
            Console.WriteLine(sum);
        }
    }
}