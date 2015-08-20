/*
Problem 18. Extract e-mails
Write a program for extracting all email addresses from given text.
All sub-strings that match the format  <identifier>@<host>…<domain>  should be recognized as emails.
*/

using System;
using System.Collections.Generic;
class ExtractЕМails
{
    static void Main()
    {
        Console.Write("Ënter text: ");
        string text = Console.ReadLine();

        string[] splittedText = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> result = new List<string>();

        foreach (var substring in splittedText)
        {
            if (substring.Contains("@") && substring.Contains("."))
            {
                result.Add(substring);
            }
        }
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]); 
        }
    }
}

