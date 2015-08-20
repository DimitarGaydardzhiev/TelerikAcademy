
/*
Problem 13. Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
• The input is entered as string. The output should be a variable of type long.
• Do not use the built-in .NET functionality.
*/
using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please, enter a binary number: ");
        string n = Console.ReadLine();


        int numberLength = n.Length;
        double currentNumber = 0;
        double result = 0;

        string[] binary = new string[numberLength];
        string[] reversedBinary = new string[numberLength];

        for (int i = 0; i < numberLength; i++)
        {
            binary[i] = n.Substring(i, 1);
        }

       for (int i = 0; i < numberLength; i++)
        {
            reversedBinary[numberLength - i - 1] = binary[i];
        }

        for (int i = 0; i <numberLength; i++)
        {
            if (reversedBinary[i] == "1")
            {
                currentNumber = Math.Pow(2,i);
                result += currentNumber;
            }
        }
        Console.WriteLine("The decimal representation is: {0}", result);
    }
}

