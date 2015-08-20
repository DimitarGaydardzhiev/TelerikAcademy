/*
Problem 3. Sequence n matrix
We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/
/*Examples:
{"s", "qq", "s"},     |           {"ha", "fifi", "ho", "hi"},  
{"pp", "pp", "s"},     |          {"fo", "ha", "hi", "xx"},  
{"pp", "qq", "s"},    |           {"xxx", "ho", "ha", "xx"},    
*/
using System;
using System.Collections.Generic;
class SequenceNMatrix
{
    static void Main()
    {

        string[,] matrix = {
                                 {"ha", "fifi", "ho", "hi"},
                                 {"fo", "ha", "hi", "xx"},  
                                 {"xxx", "ho", "ha", "xx"},  

                           };
        string result = "";
        int longest = 0;
        int counter = 1;

        //check for equal elements on the same row:
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colStore = col;
                int rowStore = row;

                while ((col < matrix.GetLength(1) - 1) && (matrix[row, col].Equals(matrix[row, col + 1])))
                {
                    col++;
                    counter++;
                    if (counter>longest)
                    {
                        longest = counter;
                        result = matrix[row, col];
                    }
                }
                counter = 1;
                col = colStore;
                while ((row < matrix.GetLength(0) - 1) && (matrix[row, col].Equals(matrix[row + 1, col])))
                {
                    row++;
                    counter++;
                    if (counter > longest)
                    {
                        longest = counter;
                        result = matrix[row, col];
                    }
                }
                counter = 1;
                row = rowStore;
                while ((row < matrix.GetLength(0) - 1) && (col < matrix.GetLength(1) - 1) && (matrix[row, col].Equals(matrix[row + 1, col + 1])))
                {
                    col++;
                    row++;
                    counter++;
                    if (counter > longest)
                    {
                        longest = counter;
                        result = matrix[row, col];
                    }
                }
                counter = 1;
                col = colStore;
                row = rowStore;
            }
        }
        for (int i = 0; i < longest; i++)
        {
            Console.Write("{0} ", result);
        }
        Console.WriteLine();
    }
}
	
