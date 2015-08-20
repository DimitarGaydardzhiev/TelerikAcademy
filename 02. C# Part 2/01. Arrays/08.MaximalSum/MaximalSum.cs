/*
Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
*/
using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int currentSum = 0;
        int LeftEndIndex = 0;
        int RightEndIndex = 0;
        int maxSum = Int32.MinValue;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = i; j < N; j++)
            {
                currentSum += arr[j];

                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    LeftEndIndex = i;
                    RightEndIndex = j;
                }
            }
            currentSum = 0;
        }
        for (int i = LeftEndIndex; i <= RightEndIndex; i++)
        {
            Console.WriteLine("{0} ", arr[i]);
        }
    }
}