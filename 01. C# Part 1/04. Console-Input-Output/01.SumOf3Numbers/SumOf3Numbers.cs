
//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class SumOf3Numbers
{
    static void Main()
    {

        Console.Write("Please enter  first number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Please enter  second number: ");
        string secondNumber = Console.ReadLine();

        Console.Write("Please enter  third number: ");
        string thirdNumber = Console.ReadLine();

        double firstN = double.Parse(firstNumber);
        double secondN = double.Parse(secondNumber);
        double thirdN = double.Parse(thirdNumber);

        double sum = firstN+secondN+thirdN;

        Console.WriteLine("The sum of your numbers is: {0}", sum);

    }
}

