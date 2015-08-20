

//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        string a;
        Console.Write("Enter number: ");
        a = Console.ReadLine();

        int b = int.Parse(a);

        if (b%2==0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

