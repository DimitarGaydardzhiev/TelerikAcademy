/*
Problem 2. Concatenate text files
Write a program that concatenates two text files into another text file.
*/
using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader("firstFille.txt");
        StreamReader secondFile = new StreamReader("secondFile.txt");
        StreamWriter result = new StreamWriter("result.txt");

        using (result)
        {
            using (firstFile)
            {
                result.Write(firstFile.ReadToEnd());
            }
            using (secondFile)
            {
                result.Write(secondFile.ReadToEnd());
            }
        }
    }
}
