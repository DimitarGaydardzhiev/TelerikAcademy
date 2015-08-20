/*
Problem 10. Add/Delete calls
• Add methods in the  GSM  class for adding and deleting calls from the calls history.
• Add a method to clear the call history.
*/
using System;

namespace AddDeleteCalls
{
    class MainProgram
    {
        static void Main()
        {
            GSM gsm = new GSM("Lumia", "Nokia");

            gsm.AddCalls(DateTime.Now, "0889976484", 45);
            gsm.AddCalls(DateTime.UtcNow, "088956454", 23);
            gsm.AddCalls(DateTime.Now.AddHours(13), "0883076494", 5);

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.Write("{0}, {1}, {2}",gsm.CallHistory[i].DateAndTime, gsm.CallHistory[i].DialedPhoneNumber,gsm.CallHistory[i].Duration);
                Console.WriteLine();
            }

            Console.WriteLine();
            gsm.DeleteCalls("0883076494");

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.Write("{0}, {1}, {2}", gsm.CallHistory[i].DateAndTime, gsm.CallHistory[i].DialedPhoneNumber, gsm.CallHistory[i].Duration);
                Console.WriteLine();
            }

            gsm.ClearHistory();
            Console.WriteLine();

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.Write("{0}, {1}, {2}", gsm.CallHistory[i].DateAndTime, gsm.CallHistory[i].DialedPhoneNumber, gsm.CallHistory[i].Duration);
                Console.WriteLine();
            }
        }
    }
}