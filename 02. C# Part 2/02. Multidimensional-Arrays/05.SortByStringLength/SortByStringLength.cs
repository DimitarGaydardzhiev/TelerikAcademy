/*
Problem 5. Sort by string length
You are given an array of strings. Write a method that sorts the array by the length
of its elements (the number of characters composing them).
*/
using System;
using System.Collections.Generic;
using System.Linq;
class SortByStringLength
{
    static void Main()
    {

        List<string> strArr = new List<string>() { "das", "dadsaf", "ss", "gsaw", "ddsd", "s" };

        var sortedStr = strArr.OrderBy(s => s.Length).ThenBy(s => s);

        foreach (var item in sortedStr)
        {
            Console.Write(item + " ");
        }
    }
}
