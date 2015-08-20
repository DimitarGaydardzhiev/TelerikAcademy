
//Problem 9. Sum of n Numbers
//Write a program that enters a number  n  and after that enters more  n  numbers and calculates and prints their  sum . 

using System;

class SumOfNNumbers
{
    static void Main()
    {
        
       Console.WriteLine("Enter the number of numbers: "); 
       int n = int.Parse(Console.ReadLine()); 
       double sum = 0; 
        for (int i = 0; i < n; i++) 
        { 
            double num = double.Parse(Console.ReadLine()); 
            sum += num;
        } 
        Console.WriteLine("The sum of the numbers is: {0}", sum); 
    }
}