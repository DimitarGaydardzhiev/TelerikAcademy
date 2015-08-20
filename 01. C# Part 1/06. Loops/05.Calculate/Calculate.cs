
/*
Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
Write a program that, for a given two integer numbers  n  and  x , calculates the sum  S = 1 + 1!/x + 2!/x2 + … + n!/x^n .
• Use only one loop. Print the result with  5  digits after the decimal point.
 * */

using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Please, enter first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter second number: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1M;
        decimal currentSum = 0M;
        decimal fact = 1M;
        decimal power = 0M;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            power = (decimal)Math.Pow(x,i);
            currentSum = fact / power;
            sum += currentSum;
        }
        Console.WriteLine("{0:F5}", sum);
            
    }
}

