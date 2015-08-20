/*
Problem 6. Save sorted names
• Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:

input.txt             output.txt
 
 Ivan                   George
 Peter                  Ivan
 Maria                  Maria
 George                 Peter
*/
using System;
using System.IO;
using System.Linq;
class SaveSortedNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt");

        using (reader)
        {
            string names = reader.ReadToEnd();

            string[] arrNames = names.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(arrNames);

            using (writer)
            {
                for (int i = 0; i < arrNames.Length; i++)
                {
                    writer.WriteLine(arrNames[i].ToString().Trim());
                }
            }
        }
    }
}

