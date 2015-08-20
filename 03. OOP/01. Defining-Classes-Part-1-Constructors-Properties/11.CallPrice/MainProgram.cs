/*
Problem 11. Call price
• Add a method that calculates the total price of the calls in the call history.
• Assume the price per minute is fixed and is provided as a parameter.
*/
using System;

namespace CallPrice
{
    class MainProgram
    {
        static void Main()
        {
            GSM gsm = new GSM("Lumia", "Nokia");

            gsm.AddCalls(DateTime.Now, "0889976484", 45);
            gsm.AddCalls(DateTime.UtcNow, "088956454", 23);
            gsm.AddCalls(DateTime.Now.AddHours(13), "0883076494", 5);

            gsm.TotalPrice(2);
        }
    }
}
