/*
Problem 8. Binary short
Write a program that shows the binary representation of given 16-bit signed integer number (the C# type  short ).
*/
using System;
class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a number of type short N = ");
        short N = short.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of {0} is => {1}", N, Convert.ToString(N,2));
    }
}
