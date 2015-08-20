/*
Problem 6. First larger than neighbours
Write a method that returns the index of the first element in array that is larger than its neighbours,
or  -1 , if there’s no such element.
Use the method from the previous exercise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
class LargerThanNeighbours
{

    static int checkElementNeighbours(List<int> arr)
    {
        for (int i = 1; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return arr.IndexOf(arr[i]);
            }
        }
        return -1;
    }
    static void Main()
    {
        Console.Write("Enter, number of elements: ");
        int numberOfElements = int.Parse(Console.ReadLine());

        List<int> arr = new List<int>();

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr.Add(int.Parse(Console.ReadLine()));
        }

        int result = checkElementNeighbours(arr);
        Console.WriteLine(result);
    }
}

