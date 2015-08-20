
//Problem 14.Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program
//that prints the entire ASCII table of characters on the console (characters from 0 to 255).

using System;
using System.Collections.Generic;

class ASCIITablePrint
{
    static void Main()
    {
        int i;
        for (i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0}={1}", i, (char)i);
        }
    }
}