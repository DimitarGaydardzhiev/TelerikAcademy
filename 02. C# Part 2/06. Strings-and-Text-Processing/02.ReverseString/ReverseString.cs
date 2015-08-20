/*
Problem 2. Reverse string
Write a program that reads a string, reverses it and prints the result at the console.
*/
using System;
using System.Text;
class ReverseString
{

    static StringBuilder ReverseStr(string text)
    {
        StringBuilder result = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            result.Append(text[i]);
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter string => ");
        string str = Console.ReadLine();

        var result = ReverseStr(str);

        Console.WriteLine("The reversed string is => {0}", result);
    }
}

