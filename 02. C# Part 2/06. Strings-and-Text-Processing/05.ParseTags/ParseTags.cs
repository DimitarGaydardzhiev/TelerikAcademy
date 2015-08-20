/*
Problem 5. Parse tags
You are given a text. Write a program that changes the text in all regions surrounded by the tags  <upcase>  and  </upcase>  to upper-case.
• The tags cannot be nested.

*/
using System;
using System.Text;
class ParseTags
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                i += 8;
                while (text[i] != '<')
                {
                    builder.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += 9;
            }
            else
            {
                builder.Append(text[i]);
            }
        }
        Console.WriteLine(builder.ToString());
    }
}
