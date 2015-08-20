/*
Problem 12. Remove words
• Write a program that removes from a text file all words listed in given another text file.
• Handle all possible exceptions in your methods.
*/
using System;
using System.IO;
using System.Collections.Generic;
class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader readerText = new StreamReader("text.txt");
            StreamReader readerWords = new StreamReader("WordsToRemove.txt");
            StreamWriter writer = new StreamWriter("TextWithoutListedWords.txt");

            string currentWord;
            string line = readerText.ReadLine();
            List<string> words = new List<string>();

            using (readerWords)
            {
                currentWord = readerWords.ReadLine();
                while (currentWord != null)
                {
                    words.Add(currentWord);
                    currentWord = readerWords.ReadLine();
                }
            }

            using (readerText)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            line = line.Replace(words[i], "");
                        }
                        writer.WriteLine(line);
                        line = readerText.ReadLine();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
        }
    }
}

