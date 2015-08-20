
//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a>c&&a>b)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }
        if (b > a && b > c)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }
        if (c > a && c > b)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }
    }
}
