/*
Problem 5. Maximal area sum
• Write a program that reads a text file containing a square matrix of numbers.
• Find an area of size  2 x 2  in the matrix, with a maximal sum of its elements. 
◦ The first line in the input file contains the size of matrix  N .
◦ Each of the next  N  lines contain  N  numbers separated by space.
◦ The output should be a single number in a separate text file.

Example:

input                 output

 4                      17
 2 3 3 4 
 0 2 3 4 
 3 7 1 2 
 4 3 3 2 
*/
using System;
using System.IO;
using System.Collections.Generic;
class MaximalAreaSum
{
    static int BestSum (int[,] arr)
    {
        int currentSum = 0;
        int sum = int.MinValue; ;

        for (int row = 0; row < arr.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 1; col++)
            {
                currentSum = arr[row, col] + arr[row, col + 1] + arr[row + 1, col] + arr[row + 1, col + 1];
                if (currentSum>sum)
                {
                    sum = currentSum;
                }
            }
        }
        return sum;
    }
    static void Main()
    {
        StreamReader reader = new StreamReader("matrix.txt");
        StreamWriter writer = new StreamWriter("BestSumInMatrix.txt");

        using (reader)
        {
            int size = int.Parse(reader.ReadLine());
            string[] file = reader.ReadToEnd().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[,] arr = new int[size, size];
            int indexer = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    arr[row, col] = int.Parse(file[indexer].ToString());
                    indexer++;
                }
            }
            using (writer)
            {
                int result = BestSum(arr);
                writer.WriteLine(result);
            }
        }
    }
}

