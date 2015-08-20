/*
Problem 20. Palindromes
Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe .
*/
using System;
using System.Collections.Generic;
class Palindromes
{
    static void Main()
    {
        Console.Write("enter text: ");
        string text = Console.ReadLine();

        string[] splittedText = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();

        for (int i = 0; i < splittedText.Length; i++)
        {
            string firstPart = splittedText[i].Substring(0, splittedText[i].Length / 2);
            char[] arr = splittedText[i].ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string secondPart = temp.Substring(0, temp.Length / 2);

            if (firstPart.Equals(secondPart))
            {
                palindromes.Add(splittedText[i]);
            }
        }

        Console.WriteLine("List of palindromes in the text: ");

        for (int i = 0; i < palindromes.Count; i++)
        {
            Console.WriteLine(palindromes[i]);
        }
    }
}

