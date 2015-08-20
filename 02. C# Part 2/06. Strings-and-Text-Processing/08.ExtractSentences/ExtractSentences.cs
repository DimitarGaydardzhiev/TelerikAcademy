﻿
/*
Problem 8. Extract sentences
Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by  .  and the words – by non-letter symbols.
*/
using System;
using System.Text;
class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        string[] newText = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < newText.Length; i++)
        {
            if (newText[i].Contains(" " + word + " ") || newText[i].Contains(word + " ") || newText[i].Contains(" " + word))
            {
                result.Append(newText[i]);
                result.Append(".");
            }
        }
        Console.WriteLine(result);
    }
}

