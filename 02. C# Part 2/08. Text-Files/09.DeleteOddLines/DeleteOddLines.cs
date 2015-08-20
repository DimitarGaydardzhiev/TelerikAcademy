/*
Problem 9. Delete odd lines
• Write a program that deletes from given text file all odd lines.
• The result should be in the same file.
*/
using System;
using System.IO;
class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("text.txt");
        StreamWriter writer = new StreamWriter("resultWithRemovedOddLines.txt");

        int currentLine = 0;

        using (reader)
        {
            string readedLine = reader.ReadLine();

            using (writer)
            {
                do
                {
                    currentLine++;

                    if (currentLine % 2 == 1)
                    {
                        writer.WriteLine(readedLine);
                    }

                    readedLine = reader.ReadLine();

                } while (readedLine != null);
            }
        }
        File.Delete("text.txt");
        File.Copy("resultWithRemovedOddLines.txt", "text.txt");
        File.Delete("resultWithRemovedOddLines.txt");
    }
}

