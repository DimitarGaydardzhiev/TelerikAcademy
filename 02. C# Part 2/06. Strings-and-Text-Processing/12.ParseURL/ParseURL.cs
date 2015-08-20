/*
Problem 12. Parse URL
Write a program that parses an URL address given in the format:
[protocol]://[server]/[resource]  and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.
*/
using System;
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string URL = Console.ReadLine();
        URL = URL.Replace(".com",".com*");

        string[] parsedURL = URL.Split(new string[]{"//", ":", "*"}, StringSplitOptions.RemoveEmptyEntries);
        string[] result = {
                              "[protocol] = ",
                              "[server] = ",
                              "[resource] = "
                          };

        for (int i = 0; i < parsedURL.Length; i++)
        {
            Console.WriteLine("{0}{1}", result[i], parsedURL[i]);
        }
    }
}
