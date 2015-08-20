

//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is  7 .

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter number: ");
        number = Console.ReadLine();

        int newNumber = int.Parse(number);

        newNumber /= 100;
        bool result = newNumber % 10 == 7;

        Console.WriteLine(result);
            

    }
}

