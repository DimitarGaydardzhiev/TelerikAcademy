/*
Problem 10. N Factorial
Write a program to calculate  n!  for each  n  in the range [ 1..100 ].
*/
using System;
using System.Numerics;
class NFactorial
{
    static BigInteger Factorial (BigInteger N)
    {
        BigInteger result = 1;

        if (N < 0 || N > 100)
        {
            Console.WriteLine("Not a valid number!");
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter a number from 0 to 100 n = ");
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        BigInteger result = Factorial(N);

        if (N >= 0 && N <= 100)
        {
            Console.WriteLine("{0}! = {1}", N, result);
        }
    }
}

