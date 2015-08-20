//Problem 1. Exchange if greater
//Write an if-statement that takes two double variable a and b and exchange their values if the first one is greater
//than the second one. As a result point the values separated by a space.
using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());

        double c = 0;
        double d = 0;
        
        if (a>b)
        {
            c = a;
            d = b;
            Console.WriteLine("{0} {1}", d, c);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

