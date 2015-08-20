/*
Problem 9. Forbidden words
We are given a string containing a list of forbidden words and a text containing some of these words.
• Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words:  PHP ,  CLR ,  Microsoft 

The expected result:  ********* announced its next generation *** compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in *** .
*/
using System;
using System.Text;
class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter forbidden words (separate them with ','): ");
        string forbWords = Console.ReadLine();

        string[] splitForbWords = forbWords.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        for (int i = 0; i < splitForbWords.Length; i++)
        {
            string replaceString = new string('*', splitForbWords[i].Trim().Length);
            text = text.Replace(splitForbWords[i].Trim(), replaceString);
        }
        Console.WriteLine(text);
    }
}

