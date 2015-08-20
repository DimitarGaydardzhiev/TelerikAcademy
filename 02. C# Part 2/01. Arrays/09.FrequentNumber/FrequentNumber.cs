/*
Problem 9. Frequent number
Write a program that finds the most frequent number in an array.
*/
using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        int counter = 0;
        int frequentNumber = 0;
        int mostFrequent = Int32.MinValue;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i]==arr[j])
                {
                    counter++;
                }
                if (counter>=mostFrequent)
                {
                    frequentNumber = arr[i];
                    mostFrequent = counter;
                }
            }
            counter = 0;
        }
        Console.WriteLine("{0}, {1} times", frequentNumber, mostFrequent);
    }
}

