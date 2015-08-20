/*
Problem 7. Reverse number
Write a method that reverses the digits of given decimal number.
*/
using System;
using System.Collections.Generic;
class ReverseNumber
{
    static List<char> Reverse (decimal number)
    {
        string str = Convert.ToString(number);
        List<char> digitList = new List<char>();

        foreach (var symbol in str)
        {
            digitList.Add(symbol);
        }
        
        digitList.Reverse();
        return digitList;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        List<char> result = Reverse(number);

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
