/*
Problem 19. Dates from text in Canada
Write a program that extracts from a given text all dates that match the format  DD.MM.YYYY .
Display them in the standard date format for Canada.
*/
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Threading;
class DatesFromTextInCanada
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string[] splittedText = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        DateTime dates = new DateTime();

        for (int i = 0; i < splittedText.Length; i++)
        {
            if (splittedText[i].Contains(".") && splittedText[i].Contains("."))
            {
                result.Add(splittedText[i]);
            }
        }
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        for (int i = 0; i < result.Count; i++)
        {
            dates = DateTime.ParseExact(result[i], "dd.mm.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dates);
        }
    }
}
