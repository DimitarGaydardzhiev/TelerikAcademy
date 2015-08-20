

//Problem 6. Strings and Objects
//Declare two string variables and assign them with  Hello  and  World .
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class StringsandObjects
{
    static void Main()
    {
        string H = "Hello";
        string W = "World";
        object HW = "Hello World";

        string Hi = (string)HW;

        Console.WriteLine(Hi);
        
    }
}

