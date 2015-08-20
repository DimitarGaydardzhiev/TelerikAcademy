

//Problem 13. Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 .

using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        string firstNumber;
        string secondNumber;
        
        Console.Write("Enter First Number:");
        firstNumber = Console.ReadLine();

        Console.Write("Enter Second Number:");
        secondNumber = Console.ReadLine();

        double first = double.Parse(firstNumber);
        double second = double.Parse(secondNumber);

        if (Math.Abs(first - second) < 0.000001)
        {
        Console.WriteLine("True, the two numbers are equal");
        }
        else
        {
        Console.WriteLine("False, the two numbers aren't equal");
        }
    }
}