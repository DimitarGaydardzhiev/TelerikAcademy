

//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position  p  (counting from  0 , starting from the right) in given integer number  n , has value of 1.

using System;

class CheckABit
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter number:");
        number = Console.ReadLine();

        string numberPosition;
        Console.WriteLine("Enter the bit position:");
        numberPosition = Console.ReadLine();

        int n = int.Parse(number);

        int p = int.Parse(numberPosition);

        int mask = 1 << p;

        int check = n & mask;

        int mask2 = check >> p;

        bool result = mask2 == 1;

        Console.WriteLine(result);
    }
}

