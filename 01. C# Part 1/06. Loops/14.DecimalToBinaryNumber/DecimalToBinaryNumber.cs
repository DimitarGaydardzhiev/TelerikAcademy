/*
Problem 14. Decimal to Binary Number
 * Using loops write a program that converts an integer number to its binary representation.
• The input is entered as long. The output should be a variable of type string.
• Do not use the built-in .NET functionality.
*/

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter number: ");
        int number = int.Parse(Console.ReadLine());

        string result = "";

        
        if (number==0)
        {
            Console.WriteLine(number);
        }
        else
        {
            while (number >= 1)
            {
                result = (number % 2) + result;

                number /= 2;
            }
            Console.WriteLine(result);
        }
    }
}

