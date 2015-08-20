/*
Problem 15. Replace tags
Write a program that replaces in a HTML document
given as string all the tags  <a href="…">…</a>  with corresponding tags  [URL=…]…/URL] .
*/
using System;
class ReplaceTags
{
    static void Main()
    {
        Console.Write("Enter HTML text: ");
        string text = Console.ReadLine();

        text = text.Replace("<a href=\"", "[URL=");
        text = text.Replace("\">", "]");
        text = text.Replace("</a>", "[/URL]");

        Console.WriteLine();
        Console.WriteLine(text);
    }
}
