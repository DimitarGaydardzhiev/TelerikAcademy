/*
Problem 16.* Subset with sum S
We are given an array of integers and a number  S .
Write a program to find if there exists a subset of the elements of the array that has a sum  S .
*/
using System;
using System.Collections.Generic;
class SubsetWithSumS
{
    static void Main()
    {
        Console.Write("Please, enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int sum = 0;
        bool flag = false;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, enter sum S = ");
        int S = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum > S)
                {
                    sum -= arr[j];
                }
                if (sum < S)
                {
                    continue;
                }
                if (sum == S)
                {
                    Console.WriteLine("Yes");
                    flag = true;
                    break;
                }
                if (sum != S)
                {
                    continue;
                }
            }
            sum = 0;
        }
        if (flag == false)
        {
            Console.WriteLine("No");
        }
    }
}

