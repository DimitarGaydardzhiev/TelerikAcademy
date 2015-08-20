/*
Problem 13. Reverse sentence
Write a program that reverses the words in given sentence.

Example:

            input                                               output

 C# is not C++, not PHP and not Delphi!             Delphi not and PHP, not C++ not is C#!  

*/
using System;
using System.Text;
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        string[] words = text.Split(new char[] { ' ', '!' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = words.Length - 1; i >= 0; i--)
        {
            result.Append(words[i] + " ");
        }
        string lastResult = result.ToString();
        lastResult = lastResult.TrimEnd();
        Console.WriteLine(lastResult + "!");
    }
}

