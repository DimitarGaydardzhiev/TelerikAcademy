/*
Problem 14. Word dictionary
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
*/
using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.Write("Enter word, to get the explanation of it: ");
        string word = Console.ReadLine();

        Console.WriteLine("{0} is: {1}",word, dictionary[word]);
    }
}

