

//Problem 11. Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
//The bits are counted from right to left, starting from bit  #0 .
//The result of the expression should be either  1  or  0 .

using System;


class ExtractBit3
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter number:");
        number = Console.ReadLine();

        int newNumber = int.Parse(number);

        int position = 3;

        int newPos = 1 << position;
        int n = newPos & newNumber;

        int result = n >> position;

        Console.WriteLine(result);
    }
}

