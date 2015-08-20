/*
Problem 7. Replace sub-string
• Write a program that replaces all occurrences of the sub-string  "start"  with the sub-string  "finish"  in a text file.
• Ensure it will work with large files (e.g.  100 MB ).
*/
using System;
using System.IO;
class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader("SomeText.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        string readLine;
        string modifiedLine;

        using (reader)
        {
            using (writer)
            {
                readLine = reader.ReadLine();

                while (readLine != null)
                {
                    modifiedLine = readLine.Replace("start", "finish");
                    writer.WriteLine(modifiedLine);
                    readLine = reader.ReadLine();
                }
            }
        }
    }
}

