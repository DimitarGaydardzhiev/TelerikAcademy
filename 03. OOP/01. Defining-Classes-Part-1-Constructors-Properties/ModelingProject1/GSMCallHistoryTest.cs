/*
Problem 12. Call history test
• Write a class  GSMCallHistoryTest  to test the call history functionality of the  GSM  class. 
◦ Create an instance of the  GSM  class.
◦ Add few calls.
◦ Display the information about the calls.
◦ Assuming that the price per minute is  0.37  calculate and print the total price of the calls in the history.
◦ Remove the longest call from the history and calculate the total price again.
◦ Finally clear the call history and print it.
*/
using System;
using System.Linq;

namespace CallHistoryTest
{
    class MainProgram
    {
        static void Main()
        {
            GSM someGSM = new GSM("Lumia", "Nokia");

            someGSM.AddCalls(DateTime.Now, "0889976484", 45);
            someGSM.AddCalls(DateTime.UtcNow, "088956454", 23);
            someGSM.AddCalls(DateTime.Now.AddHours(13), "0883076494", 5);

            for (int i = 0; i < someGSM.CallHistory.Count; i++)
            {
                Console.Write("{0}, {1}, {2}", someGSM.CallHistory[i].DateAndTime, someGSM.CallHistory[i].DialedPhoneNumber, someGSM.CallHistory[i].Duration);
                Console.WriteLine();
            }
            Console.WriteLine();
            someGSM.TotalPrice(0.37);

            someGSM.CallHistory.OrderByDescending(a => a.Duration);
            someGSM.CallHistory.RemoveAt(0);

            Console.WriteLine();
            someGSM.TotalPrice(0.37);

            Console.WriteLine();
            someGSM.ClearHistory();
            for (int i = 0; i < someGSM.CallHistory.Count; i++)
            {
                Console.Write("{0}, {1}, {2}", someGSM.CallHistory[i].DateAndTime, someGSM.CallHistory[i].DialedPhoneNumber, someGSM.CallHistory[i].Duration);
                Console.WriteLine();
            }
        }
    }
}
