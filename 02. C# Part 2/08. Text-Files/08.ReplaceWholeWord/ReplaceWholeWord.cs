/*
Problem 8. Replace whole word
• Modify the solution of the previous problem to replace only whole words (not strings).
*/
using System;
using System.IO;
class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("Text.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        string readFileLine;
        string modifiedLine;

        readFileLine = reader.ReadLine();

        Console.Write("Enter word to look for: ");
        string word = Console.ReadLine();

        Console.Write("Enter replacing word: ");
        string replacingWord = Console.ReadLine();

        using (reader)
        {
            using (writer)
            {
                while (readFileLine != null)
                {
                    modifiedLine = readFileLine.Replace(word, replacingWord);
                    writer.WriteLine(modifiedLine);
                    readFileLine = reader.ReadLine();
                }
            }
        }
    }
}

