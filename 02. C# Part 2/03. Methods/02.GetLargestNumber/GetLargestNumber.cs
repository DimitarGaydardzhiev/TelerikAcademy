/*
Problem 2. Get largest number
Write a method  GetMax()  with two parameters that returns the larger of two integers.
Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .
*/
using System;
class GetLargestNumber
{

    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = firstNumber;

        if (secondNumber>firstNumber)
        {
            maxNumber = secondNumber;
        }
        return maxNumber;
    }
    static void Main()
    {
        Console.Write("Enter first number = ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number = ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number = ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int maxOfThree = GetMax(GetMax(firstNumber, secondNumber), GetMax(secondNumber, thirdNumber));
        Console.WriteLine("The max number is: {0}", maxOfThree);
    }
}

