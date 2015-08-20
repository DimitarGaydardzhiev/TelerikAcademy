/*
Problem 8. Calls
• Create a class  Call  to hold a call performed through a GSM.
• It should contain date, time, dialled phone number and duration (in seconds).
*/
using System;

namespace Calls
{
    class Program
    {
        static void Main()
        {
            Calls callHistory = new Calls(DateTime.Now, "0883333999", 34);

            Console.Write(callHistory.DateAndTime + " " + ",");
            Console.Write(callHistory.DialedPhoneNumber + " " + ",");
            Console.Write(callHistory.Duration);
            Console.WriteLine();
        }
    }
}
