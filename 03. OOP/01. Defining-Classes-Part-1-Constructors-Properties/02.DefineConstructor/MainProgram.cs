/*
Problem 2. Constructors
• Define several constructors for the defined classes that take 
different sets of arguments (the full information for the class or part of it).
• Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
using System;

namespace DefineConstructor
{
    class MainProgram
    {
        static void Main()
        {
            Battery battery = new Battery("some battery", "Nokia Battery");
            Console.WriteLine(battery.BatteryManufacturer);

            GSM gsm = new GSM("Lumia", "Nokia");
            Console.WriteLine(gsm.Manufacturer);
        }
    }
}
