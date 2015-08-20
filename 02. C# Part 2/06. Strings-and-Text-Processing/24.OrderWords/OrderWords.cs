/*
Problem 24. Order words
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
using System;
using System.Collections.Generic;
class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter list of words (separet them by a space): ");
        string text = Console.ReadLine();

        List<string> words = new List<string>(text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        words.Sort();

        for (int i = 0; i < words.Count; i++)
        {
            Console.Write(words[i] + " ");
        }
        Console.WriteLine();
    }
}
