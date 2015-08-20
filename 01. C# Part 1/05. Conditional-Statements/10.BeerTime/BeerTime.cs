//Problem 10. Beer Time.
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enteres a time in fomat "hh:mm tt" (an hour in range [01...12], a minute in range [00...59]] and
//AM / PM designator) and prints "beer time" or "non-beer time" according to the definition above or "invalid time"
//if the time cannot be parsed

using System; //12 am - 00:00-12:00 pm = 12:00-24:00
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Please, enter time, in format hh:mm AM/PM: ");

        DateTime dAndTimeNow = DateTime.Parse(Console.ReadLine());
        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");

        if (dAndTimeNow>=startBeerTime||dAndTimeNow<endBeerTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}