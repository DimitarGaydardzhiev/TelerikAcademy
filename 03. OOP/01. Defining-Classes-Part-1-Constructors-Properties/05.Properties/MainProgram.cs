/*
Problem 5. Properties
• Use properties to encapsulate the data fields inside the  GSM ,  Battery  and  Display  classes.
• Ensure all fields hold correct data at any given time.
*/
using System;
namespace Properties
{
    class MainProgram
    {
        static void Main()
        {
            Battery battery = new Battery();

            //battery.HoursIdle = -2;
            Console.WriteLine(battery.HoursIdle);

            GSM gsm = new GSM("Lumia", "Nokia", -2, "Pesho");

        }
    }
}
