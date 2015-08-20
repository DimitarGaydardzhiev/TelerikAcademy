/*
Problem 1. Leap year
Write a program that reads a year from the console and checks whether it is a leap one.
• Use  System.DateTime .
*/
using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int Year = int.Parse(Console.ReadLine());

        bool leapYear = DateTime.IsLeapYear(Year);

        Console.WriteLine("This year is leap?: {0}", leapYear);
    }
}

