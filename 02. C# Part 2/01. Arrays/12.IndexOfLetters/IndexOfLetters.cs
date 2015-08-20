/*
Problem 12. Index of letters
Write a program that creates an array containing all letters from the alphabet ( A-Z ).
Read a word from the console and print the index of each of its letters in the array.
*/
using System;
using System.Linq;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabetLarge = new char[26];
        char[] alphabetSmall = new char[26];
        int[] count = new int[26];

        for (int i = 0; i < 26; i++)
        {
            alphabetLarge[i]=(char)(i+65);
        }
        for (int i = 0; i < 26; i++)
        {
            alphabetSmall[i] = (char)(i + 97);
        }
        for (int i = 0; i < 26; i++)
        {
            count[i] = i;
        }
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabetLarge.Length; j++)
            {
                if (word[i].Equals(alphabetLarge[j])||word[i].Equals(alphabetSmall[j]))
                {
                    Console.WriteLine("{0} -> {1}", word[i], count[j]);
                }
            }
        }
    }
}

