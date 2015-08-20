/*
Problem 3. Line numbers
Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/
using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("example.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        string lineContents = reader.ReadLine();

        int lineNumber = 0;

        using (writer)
        {
            using (reader)
            {
                do
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, lineContents);
                    lineContents = reader.ReadLine();
                } while (lineContents != null);
            }
        }
    }
}

