

//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please, enter 3 numbers: ");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a==0||b==0||c==0)
        {
            Console.WriteLine("0");
        }
        if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 & c < 0) || (a > 0 && b < 0 & c < 0))
        {
           Console.WriteLine("+");
        }
        else if (a!=0&&b!=0&&c!=0)
        {
           Console.WriteLine("-");
        }
        }
    }
