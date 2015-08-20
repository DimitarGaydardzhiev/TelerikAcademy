/*
Write a program to compare the performance of:
square root, natural logarithm, sinus
for the values:
float, double and decimal
*/
namespace CompareAdvancedMaths
{
    using System;

    public class StartingPoint
    {
        public static void Main()
        {
            dynamic value = 10000000;

            Console.WriteLine("Float Calculations:");
            Console.WriteLine();
            Calculator.FloatCalculations(value, MathOperation.NaturalLogarithm);
            Calculator.FloatCalculations(value, MathOperation.Sinus);
            Calculator.FloatCalculations(value, MathOperation.SquareRoot);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Double Calculations:");
            Console.WriteLine();
            Calculator.DoubleCalculations(value, MathOperation.NaturalLogarithm);
            Calculator.DoubleCalculations(value, MathOperation.Sinus);
            Calculator.DoubleCalculations(value, MathOperation.SquareRoot);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Decimal Calculations:");
            Console.WriteLine();
            Calculator.DecimalCalculations(value, MathOperation.NaturalLogarithm);
            Calculator.DecimalCalculations(value, MathOperation.Sinus);
            Calculator.DecimalCalculations(value, MathOperation.SquareRoot);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
