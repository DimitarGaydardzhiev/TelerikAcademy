/*
Problem 1. Define class
• Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and
display characteristics (size and number of colors).
• Define 3 separate classes (class  GSM  holding instances of the classes  Battery  and  Display ).
*/
using System;
namespace _01.DefineClass
{
    class MainProgram
    {
        static void Main()
        {
            GSM mobilePhone = new GSM();
            mobilePhone.Manufacturer = "Nokia";
            Console.WriteLine("Manufacturer: {0}", mobilePhone.Manufacturer);

            mobilePhone.Model = "Lumia 925";
            Console.WriteLine("Model: {0}", mobilePhone.Model);

            mobilePhone.Price = 540.56M;
            Console.WriteLine("Price: {0}", mobilePhone.Price);

            mobilePhone.Owner = "Mitko";
            Console.WriteLine("Owner: {0}", mobilePhone.Owner);

            mobilePhone.Battery.BatteryModel = "Nokia Batery";
            Console.WriteLine("Battery Model: {0}", mobilePhone.Battery.BatteryModel);

            mobilePhone.Battery.HoursIdle = 10;
            Console.WriteLine("Hours idle: {0}", mobilePhone.Battery.HoursIdle);

            mobilePhone.Battery.HoursTalk = 5;
            Console.WriteLine("Hours talk: {0}", mobilePhone.Battery.HoursTalk);

            mobilePhone.Display.Size = 5.2;
            Console.WriteLine("Display size: {0}", mobilePhone.Display.Size);

            mobilePhone.Display.NumberOfColors = 256000000;
            Console.WriteLine("Number of colors: {0}", mobilePhone.Display.NumberOfColors);
            Console.WriteLine();
        }
    }
}
