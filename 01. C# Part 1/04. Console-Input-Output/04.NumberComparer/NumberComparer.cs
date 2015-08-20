
//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        string firstNumber = Console.ReadLine();

        double fNumber = double.Parse(firstNumber);

        Console.Write("please enter second number: ");
        string secondNumber = Console.ReadLine();

        double sNumber = double.Parse(secondNumber);

        double result = Math.Max(fNumber, sNumber);

        Console.WriteLine("The greater number is: {0}",result);
    }
}
