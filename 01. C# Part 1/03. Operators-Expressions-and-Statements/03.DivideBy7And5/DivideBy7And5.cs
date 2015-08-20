
//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        string number;
        Console.Write("Enter number: ");
        number = Console.ReadLine();

        int newNumber = int.Parse(number);

        bool result = newNumber%5==0 && newNumber%7==0;

        Console.WriteLine("The number {0} can be divided, without reminder, by 7 and 5 at the same time: {1}", number, result);
    }
}
