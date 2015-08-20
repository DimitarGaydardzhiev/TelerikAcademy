/*
Problem 23. Series of letters
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:

        input                            output

aaaaabbbbbcdddeeeedssaa                 abcdedsa 

*/
using System;
using System.Text;
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        char currentLetter = text[0];

        for (int i = 1; i < text.Length; i++)
        {
            if (currentLetter != text[i])
            {
                result.Append(currentLetter);
                currentLetter = text[i];
            }
            if (i == text.Length-1)
            {
                result.Append(text[i]);
            }
        }

        Console.Write(result);
    }
}

