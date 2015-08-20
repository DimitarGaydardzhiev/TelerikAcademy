/*
Problem 2. Binary to decimal
Write a program to convert binary numbers to their decimal representation.
 */
using System;
using System.Collections.Generic;
class BinaryToDecimal
{
    static double convertNumber(List<double> arrBinary)
    {
        List<double> decimalNumber = new List<double>();
        double currentResult = 0;
        double result = 0;

        for (int i = 0; i < arrBinary.Count; i++)
        {
            currentResult = arrBinary[i] * (Math.Pow(2,i));
            result += currentResult;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please, enter binary number N = ");
        string binaryNumber = Console.ReadLine();

        List<double> arrBinary = new List<double>();

        foreach (var item in binaryNumber)
        {
            arrBinary.Add(item - 48);
        }
        arrBinary.Reverse();
        var result = convertNumber(arrBinary);
        Console.WriteLine(result);
    }
}
