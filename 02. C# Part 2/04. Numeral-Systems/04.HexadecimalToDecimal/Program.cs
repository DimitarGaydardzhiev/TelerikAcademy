/*
Problem 4. Hexadecimal to decimal
Write a program to convert hexadecimal numbers to their decimal representation.
*/
using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static double convertNumber(string s, int i)
    {
        if (s[i] >= 'A')
        {
            return s[i] - 'A' + 10; 
        }
        else
        {
            return s[i] - '0';
        }
    }
    
    static void Main()
    {
        Console.Write("Please enter Hexidecimal number N = ");
        string hexiNumber = Console.ReadLine();

        double result = new double();

        for (int i = 0; i < hexiNumber.Length; i++)
        {
            result += (double)(convertNumber(hexiNumber, i) * (Math.Pow(16, hexiNumber.Length - i - 1)));
        }
        Console.WriteLine(result);
        
    }
}

