/*
Problem 18.* Remove elements from array
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way
that the remaining array is sorted in increasing order.
Print the remaining sorted array.
*/
using System;
using System.Collections.Generic;
using System.Linq;
class RemoveElementsFromArray
{
    static void Main()
    {
        string line = Console.ReadLine();

        string[] arrStr = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] temp = new int[arrStr.Length];
        List<int> arr = new List<int>();

        for (int i = 0; i < arrStr.Length; i++)
        {
            temp[i] = int.Parse(arrStr[i]);
        }

        for (int i = 0; i < temp.Length; i++)
        {
            arr.Add(temp[i]);
        }

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i]==0)
            {
                arr.Remove(0);
            }
        }
        for (int i = 0; i < arr.Count-1; i++)
        {
            if (arr[i]>arr[i+1])
            {
                arr.RemoveAt(i);
                i--;
            }
        }
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
    }
}

