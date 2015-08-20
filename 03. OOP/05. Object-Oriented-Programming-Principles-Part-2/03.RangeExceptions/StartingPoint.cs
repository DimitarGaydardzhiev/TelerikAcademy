/*
Problem 3. Range Exceptions
• Define a class  InvalidRangeException<T>  that holds information about an error condition related to invalid range.
 It should hold error message and a range definition [ start … end ].
• Write a sample application that demonstrates the  InvalidRangeException<int>  and  InvalidRangeException<DateTime>  
by entering numbers in the range [ 1..100 ] and dates in the range [ 1.1.1980 … 31.12.2013 ].
*/

namespace RangeExceptions
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int someInt = int.Parse(Console.ReadLine());
            DateTime someDate = new DateTime(1979, 12, 12);

            try
            {
                if (someInt < 1 || someInt > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number, not in predifined interval", 1, 100);
                }
            }
            catch (InvalidRangeException<int>)
            {
                Console.WriteLine("InvalidRangeException<int> is thrown");
            }

            Console.WriteLine("Date: {0}", someDate);
            try
            {
                var startDate = new DateTime(1980, 11, 11);
                var endDate = new DateTime(1990, 11, 11);

                if (someDate < startDate || someDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Invalid date, not in predifined interval", startDate, endDate);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("InvalidRangeException<int> is thrown");
            }
        }
    }
}
