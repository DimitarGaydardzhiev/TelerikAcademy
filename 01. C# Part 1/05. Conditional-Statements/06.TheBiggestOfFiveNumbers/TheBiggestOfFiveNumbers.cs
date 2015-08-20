
//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.


using System;
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fourth number: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        if ((a >= b && a >= c && a >= d && a >= e))
        {
            a++;
            b--;
            c--;
            d--;
            e--;
            Console.WriteLine("The biggest number is: {0}", --a);
        }
        if ((b >= a && b >= c && b >= d && b >= e))
        {
            b++;
            a--;
            c--;
            d--;
            e--;
            Console.WriteLine("The biggest number is: {0}", --b);
        }
        if ((c >= a && c >= b && c >= d && c >= e))
        {
            c++;
            b--;
            a--;
            d--;
            e--;
            Console.WriteLine("The biggest number is: {0}", --c);
        }
        if ((d >= a && d >= b && d >= c && d >= e))
        {
            d++;
            b--;
            c--;
            a--;
            e--;
            Console.WriteLine("The biggest number is: {0}", --d);
        }
        if ((e >= a && e >= b && e >= c && e >= d))
        {
            e++;
            b--;
            c--;
            d--;
            a--;
            Console.WriteLine("The biggest number is: {0}", --e);
        }
    }
}
