/*
Problem 5. Maximal increasing sequence
Write a program that finds the maximal increasing sequence in an array.
*/
using System;
using System.Collections.Generic;

class MaximaLIncreasingSequence
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] arrStr = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrStr.Length];

        List<int> longest = new List<int>();

        int counter = 1;
        int currentLength = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                if (arr[i-1] < arr[i - 2] && currentLength==1)
                {
                    Console.Write(arr[i-1] + " ");
                }
                counter++;
                longest.Add(arr[i]);
            }
            else
            {
                if (counter > currentLength)
                {
                    currentLength = counter;
                    counter = 0;
                }
            }
        }

        for (int j = 0; j < currentLength; j++)
        {
            Console.Write("{0} ", longest[j]);
        }
        Console.WriteLine();
    }
}