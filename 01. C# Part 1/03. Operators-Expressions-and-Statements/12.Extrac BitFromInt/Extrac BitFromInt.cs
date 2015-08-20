

//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer  n  the value of given bit at index  p .

using System;
class Program
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter number:");
        number = Console.ReadLine();

        string numberPosition;
        Console.WriteLine("Enter the bit position:");
        numberPosition = Console.ReadLine();

        int newNumber = int.Parse(number);
      
        int p = int.Parse(numberPosition);

        int mask = 1 << p;

        int bit = mask & newNumber;

        int bitResult = bit >> p;

        Console.WriteLine(bitResult);

    }
}

