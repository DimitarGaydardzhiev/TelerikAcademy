/*
Problem 17. Date in Bulgarian
Write a program that reads a date and time given in the format:  day.month.year hour:minute:second  
and prints the date and time after  6  hours and  30  minutes (in the same format) along with the day of week in Bulgarian.
*/
using System;
using System.Globalization;
using System.Threading;
class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter date and time in format day.month.year hour:minute:second => ");
        string date = Console.ReadLine();

        DateTime dateTime = DateTime.ParseExact(date, "dd.MM.yy HH:mm:ss", CultureInfo.InvariantCulture);

        dateTime = dateTime.AddHours(6).AddMinutes(30);

        string nameOfTheDay = dateTime.Date.ToString("dddd", new CultureInfo("bg-BG"));

        Console.Write(dateTime + " ");
        Console.WriteLine(nameOfTheDay);
    }
}//example: 28.02.15 23:23:23

