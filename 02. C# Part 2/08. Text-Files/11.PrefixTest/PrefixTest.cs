/*
Problem 11. Prefix "test"
• Write a program that deletes from a text file all words that start with the prefix  test .
• Words contain only the symbols  0…9 ,  a…z ,  A…Z ,  _ .
*/
using System;
using System.IO;
using System.Text.RegularExpressions;
class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        string lineContent = reader.ReadLine();

        using (reader)
        {
            using (writer)
            {
                while (lineContent != null)
                {
                    lineContent = Regex.Replace(lineContent, "test", "");
                    writer.WriteLine(lineContent);
                    lineContent = reader.ReadLine();
                }
            }
        }
    }
}

