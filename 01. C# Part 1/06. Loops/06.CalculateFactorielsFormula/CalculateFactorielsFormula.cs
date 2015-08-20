
/*
Problem 6. Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements (also known as the number of combinations)
is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class CalculateFactorielsFormula
{
    static void Main()
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Please, enter k= ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNK = 1;
        BigInteger d = n - k;
        BigInteger result = 1;

        for (int i = 1; i <= n; i++)
        {                          
            factN *= i;

            if (i<=k)
            {
                factK *= i;
            }
        }
        for (int i= 1; i <= d; i++)
        {
            factNK *= i;

        }
        result = (factN) / (factK * factNK);
        Console.WriteLine(result);
    }
}