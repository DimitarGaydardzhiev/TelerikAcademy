/*
Problem 11. Random Numbers in Given Range
 * Write a program that enters  3  integers  n ,  min  and  max  ( min != max ) and prints  n  random numbers in the range  [min...max] .
*/
using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Plesse, enter n= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Plesse, enter min= ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Plesse, enter max= ");
        int max = int.Parse(Console.ReadLine());

        Random someNumber = new Random();

        for (int i = 0; i < n; i++)
        {
            int random = someNumber.Next(min, max);
            Console.Write("{0} ",random);
        }
    }
}