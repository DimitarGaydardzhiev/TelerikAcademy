/*
Problem 4. Sub-string in text
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
*/
using System;
class SubStringInText
{
    static void Main()
    {
        Console.Write("Please, enter text => ");
        string text = Console.ReadLine();
        text = text.ToLower();

        Console.WriteLine("Enter text to search for => ");
        string searchedText = Console.ReadLine();
        searchedText = searchedText.ToLower();

        int counter = 0;
        int indexer = 0;

        for (int i = 0; i < text.Length; i++)
        {
            indexer = text.IndexOf(searchedText, indexer);
            if (indexer >= 0)
            {
                counter++;
            }
            else
            {
                break;
            }
            indexer++;
        }
        Console.WriteLine(counter);
    }
}