/*
Problem 17. Longest string
• Write a program to return the string with maximum length from an array of strings.
• Use LINQ.
*/

namespace LongestString
{
    using System;
    using System.Linq;
    class MainProgram
    {
        
        static void Main()
        {
            string[] elements = new string[5]
            {
                "123456789",
                "sadfghjhkjghdfsg",
                "ds",
                "55555555555555555555",
                "098"
            };

            string result = elements.OrderByDescending(e => e.Length)
                .First();

            Console.WriteLine(result);
        }
    }
}
