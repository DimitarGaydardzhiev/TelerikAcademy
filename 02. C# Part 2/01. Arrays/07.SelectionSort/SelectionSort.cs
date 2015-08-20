/*
Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
using System;
using System.Collections.Generic;
class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        List<int> sortedArr = new List<int>();

        for (int i = 0; i < N; i++)
		{
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
		}

        int minIndex = 0;
        int counter = 0;

        do
        {
            int minValue = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<minValue)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            arr[minIndex] = Int32.MaxValue;
            sortedArr.Add(minValue);
            counter++;
        } while (counter<N);

        for (int j = 0; j < N; j++)
        {
            Console.WriteLine(sortedArr[j]);
        }
        
    }
}

