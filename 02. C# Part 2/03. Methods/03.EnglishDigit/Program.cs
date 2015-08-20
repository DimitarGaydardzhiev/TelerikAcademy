/*
Problem 3. English digit
Write a method that returns the last digit of given integer as an English word.
*/
using System;
class Program
{
    static string DigitAsWord(int number)
    {
        number %= 10;
        string[] newDigit = new string[] {"zero", "one","two","three","four","five","six","seven","eight","nine"};

        return newDigit[number];
    }
    static void Main()
    {
        Console.Write("Please, enter number = ");
        int number = int.Parse(Console.ReadLine());

        string result = DigitAsWord(number);
        
        Console.WriteLine("The last number is {0}", result);
    }
}