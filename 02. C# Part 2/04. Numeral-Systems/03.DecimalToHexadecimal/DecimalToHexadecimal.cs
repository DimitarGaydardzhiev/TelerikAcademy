/*
Problem 3. Decimal to hexadecimal
Write a program to convert decimal numbers to their hexadecimal representation.
*/
using System;
using System.Collections.Generic;
class DecimalToHexadecimal
{
    static List<string> convertNumber (int decimalNumber)
    {
        List<string> result = new List<string>();

        while (decimalNumber > 0)
        {
            string currentResult = Convert.ToString(decimalNumber % 16);
            if (currentResult == "10")
            {
                currentResult = "A";
            }
            if (currentResult == "11")
            {
                currentResult = "B";
            }
            if (currentResult == "12")
            {
                currentResult = "C";
            }
            if (currentResult == "13")
            {
                currentResult = "D";
            }
            if (currentResult == "14")
            {
                currentResult = "E";
            }
            if (currentResult == "15")
            {
                currentResult = "F";
            }
            result.Add(Convert.ToString(currentResult));
            result.Reverse();
            decimalNumber /= 16;
        } 
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please, enter decimal number N = ");
        int decimalNumber = int.Parse(Console.ReadLine());

        var result = convertNumber(decimalNumber);

        Console.Write("The number {0} in Hexidecimal numeric system is ", decimalNumber);

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

