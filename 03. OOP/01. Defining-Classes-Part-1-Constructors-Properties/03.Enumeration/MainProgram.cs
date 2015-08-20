/*
Problem 3. Enumeration
• Add an enumeration  BatteryType  (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
*/
using System;
namespace Enumeration
{
    class MainProgram
    {
        static void Main()
        {
            Battery battery = new Battery("aaa", "bbbb", 3, 4);
            Console.WriteLine(battery.BatType);
        }
    }
}