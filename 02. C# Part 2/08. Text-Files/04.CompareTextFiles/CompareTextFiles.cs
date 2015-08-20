/*
Problem 4. Compare text files
• Write a program that compares two text files line by line and prints the number of lines 
that are the same and the number of lines that are different.
• Assume the files have equal number of lines.
*/
using System;
using System.IO;
class CompareTextFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader("firstFile.txt");
        StreamReader secondFile = new StreamReader("secondFile.txt");

        string firstFileResult = firstFile.ReadLine();
        string secondFileResult = secondFile.ReadLine();

        int equalLines = 0;
        int differentLines = 0;

        do
        {
            if (firstFileResult==secondFileResult)
            {
                equalLines++;
            }
            else
            {
                differentLines++;
            }
            firstFileResult = firstFile.ReadLine();
            secondFileResult = secondFile.ReadLine();

        } while (secondFileResult != null);

        Console.WriteLine("Same lines: {0}", equalLines);
        Console.WriteLine("Different lines: {0}", differentLines);
    }
}

