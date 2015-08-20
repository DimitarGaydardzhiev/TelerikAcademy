
/*
Problem 7. Calculate N! / K!
Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
• Use only one loop.
*/
using System;

class NFactKFact
{
    static void Main()
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter k= ");
        int k = int.Parse(Console.ReadLine());

       int factN = 1;
       int factK = 1;
       int result = 1;

       for (int i = 1; i <= n; i++)
       {
           factN *= i;
           if (i<=k)
           {
               factK *= i;
           }
       }
       result = factN / factK;
       Console.WriteLine("The result is: {0}", result);
    }
}

