/*
Problem 8. Catalan Numbers• In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
• Write a program to calculate the  n  th  Catalan number by given  n  (0 ≤ n ≤ 100).
*/
using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factN = 1;
        BigInteger fact2N = 2 * n;
        BigInteger factNPLus1 = n + 1;
        BigInteger result = 1;

        for (BigInteger i = 1; i < 2 * n; i++)
        {
            fact2N *= i;
            if (i<=n)
            {
                factN *= i;
            }
        }
        for (BigInteger i = 1; i < n + 1; i++)
        {
            factNPLus1 *= i;
        }
        result = (fact2N) / (factNPLus1 * factN);
        Console.WriteLine(result);
    }
}
