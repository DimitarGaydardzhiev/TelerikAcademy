/*
Problem 1. Decimal to binary
Write a program to convert decimal numbers to their binary representation.
*/
using System;
using System.Collections.Generic;
class Program
{
    static List<int> convertNumber(int decimalNumber)
    {
        List<int> binaryNumber = new List<int>();
        do
        {
            if (decimalNumber % 2 == 0)
            {
                binaryNumber.Add(0);
            }
            else
            {
                binaryNumber.Add(1);
            }
            decimalNumber /= 2;
        }
        while (decimalNumber > 1);
        binaryNumber.Reverse();

        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Please enter decimal number N = ");
        int decimalNumber = int.Parse(Console.ReadLine());

        var result = convertNumber(decimalNumber);
        Console.Write("The number {0} in bibary numeral system is => ", decimalNumber);
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write("{0}", result[i]);
        }
        Console.WriteLine();
    }
}

