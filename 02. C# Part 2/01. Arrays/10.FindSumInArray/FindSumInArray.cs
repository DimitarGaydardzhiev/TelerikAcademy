/*
Problem 10. Find sum in array
Write a program that finds in given array of integers a sequence of given sum  S  (if present).
*/
using System;
using System.Collections.Generic;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please, enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int currentSum = 0;

        List<int> firstSeq = new List<int>();
        List<int> secondSeq = new List<int>();

        for (int i = 0; i < N; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, enter sum = ");
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                currentSum += arr[j];
                if (currentSum==sum)
                {
                    firstSeq.Add(i);
                    secondSeq.Add(j);
                }
            }
            currentSum = 0;
        }
        for (int i = 0; i < firstSeq.Count; i++)
        {
            for (int j = firstSeq[i]; j <= secondSeq[i]; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
        }
        Console.WriteLine();
    }
}

