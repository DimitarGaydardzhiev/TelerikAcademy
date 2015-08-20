/*
Problem 6. Sum integers
You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/
using System;
class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter numbers (separete them by a space): ");
        string line = Console.ReadLine();

        string[] splitLine = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int result = 0;

        int[] numbers = new int[splitLine.Length];

        for (int i = 0; i < splitLine.Length; i++)
        {
            numbers[i] = int.Parse(splitLine[i]);
            result += numbers[i];
        }

        Console.WriteLine(result);
    }
}

