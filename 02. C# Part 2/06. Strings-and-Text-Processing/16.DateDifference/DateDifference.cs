/*
Problem 16. Date difference
Write a program that reads two dates in the format:  day.month.year  and calculates the number of days between them.
*/
using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date in format dd.mm.yy => ");
        string firstDate =Console.ReadLine();

        DateTime first = DateTime.ParseExact(firstDate, "dd.mm.yy", CultureInfo.InvariantCulture);

        Console.Write("Enter first date in format dd.mm.yy => ");
        string secondDate = Console.ReadLine();

        DateTime second = DateTime.ParseExact(secondDate, "dd.mm.yy", CultureInfo.InvariantCulture);

        Console.WriteLine("{0:dd} days", second-first);
    }
}