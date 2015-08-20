/*
Problem 11. Binary search
Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/
using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Please, enter array lenght: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        Console.Write("Please, enter element value: ");
        int number = int.Parse(Console.ReadLine());

        int middleIndex = arr.Length / 2;

        bool flag = true;

        do
        {
            if (number<arr[middleIndex])
            {
                middleIndex /= 2;
            }
            if (number > arr[middleIndex])
            {
                middleIndex = middleIndex + (middleIndex / 2);
            }
            if (number == arr[middleIndex])
            {
                Console.WriteLine("The index of the element, after sorting the array, is {0}", middleIndex);
                flag = false;
            }
        } while (flag);
    }
}

