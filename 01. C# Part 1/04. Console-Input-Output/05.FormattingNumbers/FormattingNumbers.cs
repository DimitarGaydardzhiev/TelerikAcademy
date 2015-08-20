//Problem 5. Formatting Numbers
//Write a program that reads 3 numbers:
//◦ integer  a  (0 <= a <= 500)
//◦ floating-point  b  
//◦ floating-point  c  
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
//◦ The number  a  should be printed in hexadecimal, left aligned
//◦ Then the number  a  should be printed in binary form, padded with zeroes
//◦ The number  b  should be printed with 2 digits after the decimal point, right aligned
//◦ The number c should be printed with 3 digits after the decimal point, left aligned. 


using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        string first = Console.ReadLine();

        Console.Write("Enter Second Number: ");
        string second = Console.ReadLine();

        Console.Write("Enter Third Number: ");
        string third = Console.ReadLine();

        int a = int.Parse(first);
        float b = float.Parse(second);
        float c = float.Parse(third);

            Console.WriteLine("{0,-10:X} | {0,-10:} | {1,10:F2} | {2,-10:F3} |", a, b, c);
        
    }
}

