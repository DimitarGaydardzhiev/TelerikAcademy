/*
Problem 9. Sorting array
Write a method that return the maximal element in a portion of array of integers starting at given index.
• Using it write another method that sorts an array in ascending / descending order.
*/
using System;
using System.Collections.Generic;
class SortinArray
{
    static int[] InitializationArray ()
    {
        Console.Write("Enter, number of elements = ");
        int numberOfElements = int.Parse(Console.ReadLine());

        int[] arr = new int[numberOfElements];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    static int MaxElement(int index, int[] arr)
    {
        int bestElement = 0;

        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i]>bestElement)
            {
                bestElement = arr[i];
            }
        }
        return bestElement;
    }

    static List<int> SortAscending(int[] arr)
    {
        int minIndex = 0;
        int counter = 0;
        List<int> sortedArr = new List<int>();

        do
        {
            int minValue = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            arr[minIndex] = Int32.MaxValue;
            sortedArr.Add(minValue);
            counter++;
        } while (counter < arr.Length);

        return sortedArr;
    }
    static List<int> SortDescending(int[] arr)
    {
        int minIndex = 0;
        int counter = 0;
        List<int> sortedArr = new List<int>();

        do
        {
            int minValue = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            arr[minIndex] = Int32.MaxValue;
            sortedArr.Add(minValue);
            counter++;
        } while (counter < arr.Length);
        sortedArr.Reverse();
        return sortedArr;
    }
    static void Main()
    {
        int[] arr = InitializationArray();
        Console.WriteLine("Please, enter index: ");
        int index = int.Parse(Console.ReadLine());
        int result = MaxElement(index, arr);

        Console.WriteLine("The biggest element in the array, after index number {0} is: {1}", index, result);

        Console.WriteLine("Enter an option for sorting the array:");
        Console.WriteLine("1. Sort the array in ascending order");
        Console.WriteLine("2. Sort the array in descending order");
        int numberChoice = int.Parse(Console.ReadLine());

        if (numberChoice == 1)
        {
            var sertedAsc = SortAscending(arr);
            Console.WriteLine("The sroted array in ascending order is:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(sertedAsc[i] + " ");
            }
            Console.WriteLine();
        }
        else if (numberChoice == 2)
        {
            var sertedDsc = SortDescending(arr);
            Console.WriteLine("The sroted array in ascending order is:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(sertedDsc[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Not a valid choice!");
        }
    }
}

