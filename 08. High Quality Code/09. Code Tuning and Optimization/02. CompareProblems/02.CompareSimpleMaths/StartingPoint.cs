/*
Write a program to compare the performance of:
add, subtract, increment, multiply, divide
for the values:
int, long, float, double and decimal
*/
namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class StartingPoint
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            dynamic value = 10000000;

            Console.WriteLine("Calculating with {0} iterations for each operation.", value);
            Console.WriteLine();

            Console.WriteLine("Integers calculations: ");
            Console.WriteLine();
            Calculator.CalculateInteger(value, Operation.Addition);
            Calculator.CalculateInteger(value, Operation.Divide);
            Calculator.CalculateInteger(value, Operation.Multiply);
            Calculator.CalculateInteger(value, Operation.Subtract);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Double calculations: ");
            Console.WriteLine();
            Calculator.CalculateDouble(value, Operation.Addition);
            Calculator.CalculateDouble(value, Operation.Divide);
            Calculator.CalculateDouble(value, Operation.Multiply);
            Calculator.CalculateDouble(value, Operation.Subtract);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Long calculations: ");
            Console.WriteLine();
            Calculator.CalculateLong(value, Operation.Addition);
            Calculator.CalculateLong(value, Operation.Divide);
            Calculator.CalculateLong(value, Operation.Multiply);
            Calculator.CalculateLong(value, Operation.Subtract);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Float calculations: ");
            Console.WriteLine();
            Calculator.CalculateFloat(value, Operation.Addition);
            Calculator.CalculateFloat(value, Operation.Divide);
            Calculator.CalculateFloat(value, Operation.Multiply);
            Calculator.CalculateFloat(value, Operation.Subtract);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Decimal calculations: ");
            Console.WriteLine();
            Calculator.CalculateDecimal(value, Operation.Addition);
            Calculator.CalculateDecimal(value, Operation.Divide);
            Calculator.CalculateDecimal(value, Operation.Multiply);
            Calculator.CalculateDecimal(value, Operation.Subtract);
            Console.WriteLine("-----------------------------------");
        }
    }
}
