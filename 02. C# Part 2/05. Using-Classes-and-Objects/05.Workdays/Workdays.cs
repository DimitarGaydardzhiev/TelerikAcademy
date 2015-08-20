/*
Problem 5. Workdays
Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/
using System;
class Workdays
{
    static int NumberOfWorkdays (DateTime date)
    {
        DateTime[] publicHolidays = new DateTime[]
        {
            new DateTime(date.Year,3,3),
            new DateTime(date.Year,5,24),
            new DateTime(date.Year,9,6),
            new DateTime(date.Year,9,22),
            new DateTime(date.Year,11,1),
            new DateTime(date.Year,12,24),
            new DateTime(date.Year,12,25),
            new DateTime(date.Year,12,31),
            new DateTime(date.Year,1,1)
        };

        int workdayCounter = 0;

        for (DateTime i = DateTime.Now.Date; i < date; i = i.AddDays(1))
        {
            if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
            {
                continue;
            }
            if (i == publicHolidays[0] || i == publicHolidays[1] || i == publicHolidays[2] || i == publicHolidays[3] || i == publicHolidays[4] || i == publicHolidays[5] || i == publicHolidays[6] || i == publicHolidays[7] || i == publicHolidays[8])
            {
                continue;
            }
            else
            {
                workdayCounter++;
            }
        }
        return workdayCounter;
    }
    static void Main()
    {
        Console.Write("Please enter date in the format dd.mm.yyyy = ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        int result = NumberOfWorkdays(date);

        Console.WriteLine("The workdays between today and {0} are: {1}", date, result);
    }
}