/*
Problem 2. Maximal sum
Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  that has maximal sum of its elements.
*/
using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter size N = ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter size M = ");
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M];
        int[,] maxMatrix = new int[3, 3];

        //N - rows;
        //M - cols;

        int maxSum = int.MinValue;
        int currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                int number = int.Parse(Console.ReadLine());
                matrix[row, col] = number;
            }
        }
        if (N >= 3 && M >= 3)
        {
            for (int row = 1; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1)-1; col++)
                {
                    currentSum = matrix[row - 1, col - 1] + matrix[row - 1, col]
                        + matrix[row - 1, col + 1] + matrix[row, col - 1]
                        + matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col - 1] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;

                        //Filling the maxMatrix with the values, that make the  biggest sum:
                        maxMatrix[0, 0] = matrix[row - 1, col - 1];
                        maxMatrix[0, 1] = matrix[row - 1, col];
                        maxMatrix[0, 2] = matrix[row - 1, col + 1];
                        maxMatrix[1, 0] = matrix[row, col - 1];
                        maxMatrix[1, 1] = matrix[row, col];
                        maxMatrix[1, 2] = matrix[row, col + 1];
                        maxMatrix[2, 0] = matrix[row + 1, col - 1];
                        maxMatrix[2, 1] = matrix[row + 1, col];
                        maxMatrix[2, 2] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine("The maximal sum is: {0}", maxSum);
            Console.WriteLine("In the submatrix:");

            //printing the max matrix:
            for (int row = 0; row < maxMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxMatrix.GetLength(1); col++)
                {
                    Console.Write(maxMatrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The matrix is less than 3x3!");
        }
        
    }
}

