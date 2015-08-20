/*
Problem 1. Odd lines
Write a program that reads a text file and prints on the console its odd lines.
*/
using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("example.txt");

        using (reader)
        {
            string lineContents = reader.ReadLine();
            int lineNumber = 0;

            do
            {
                lineNumber++;
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, lineContents);
                }
                lineContents = reader.ReadLine();

            } while (lineContents != null);
        }
        
    }
}
