/*
Problem 6. String length
Write a program that reads from the console a string of maximum  20  characters.
If the length of the string is less than  20 , the rest of the characters should be filled with  * .
• Print the result string into the console.
*/
using System;
using System.Text;
class StringLength
{
    static void Main()
    {
        Console.Write("Enter text (max 20 symbols): ");
        StringBuilder symbols = new StringBuilder();
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            symbols.Append(text[i]);
        }
        if (symbols.Length > 20)
        {
            Console.WriteLine("Please enter max 20 symbols!");
        }
        else
        {
            while (symbols.Length < 20)
            {
                symbols.Append("*");
            }
            Console.WriteLine(symbols);
        }
    }
}

