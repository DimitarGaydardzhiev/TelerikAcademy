/*
Problem 5. Larger than neighbours
Write a method that checks if the element at given position in given array of integers is
larger than its two neighbours (when such exist).
*/
using System;
class LargerThanNeighbours
{
    static int[] initializeArray()
    {
        Console.Write("Enter, number of elements: ");
        int numberOfElements = int.Parse(Console.ReadLine());

        int[] arr = new int[numberOfElements];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static bool checkElementNeighbours(int[] arr, int position)
    {
        bool flag = false;
        for (int i = 1; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
            {
                flag = true;
            }
        }
        return flag;
    }
    static void Main()
    {
        int[] arr = initializeArray();
        Console.WriteLine("Enter position to check: ");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position <= arr[arr.Length-1])
        {
            bool result = checkElementNeighbours(arr, position);
            Console.WriteLine("The element at the choesen position is larger than its neighbours?: {0}", result);
        }
        else
        {
            Console.WriteLine("No such position in the array!");
        }
    }
}
