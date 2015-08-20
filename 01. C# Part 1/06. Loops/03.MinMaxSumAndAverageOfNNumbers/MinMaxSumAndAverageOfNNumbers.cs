/*
Problem 3. Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, the maximal number,
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
• The output is like in the examples below.
 */
using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write(""); //number of numbers
        int numberOfNumbers = int.Parse(Console.ReadLine());

        double currentNumber = 0;
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double average = 0;

        for (int i = 0; i < numberOfNumbers; i++)
        {
            currentNumber = double.Parse(Console.ReadLine());
            sum += currentNumber;
            average = sum / numberOfNumbers;

            if (currentNumber>max)
            {
                max = currentNumber;
            }
            if (currentNumber<min)
            {
                min = currentNumber;
            }
        }
        Console.WriteLine("min={0:F0}", min);
        Console.WriteLine("max={0:F0}", max);
        Console.WriteLine("sum={0:F0}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}

