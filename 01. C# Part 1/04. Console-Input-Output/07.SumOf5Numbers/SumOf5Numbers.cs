// Problem 7. Sum of five numbers
// Write a program that enteres 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers (separete them by a space): ");

        string[] numbers = new string[5];
        numbers = Console.ReadLine().Split();

        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)

        {
            sum += Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine("The sum of the numbers is: {0}", sum);     
    }
}