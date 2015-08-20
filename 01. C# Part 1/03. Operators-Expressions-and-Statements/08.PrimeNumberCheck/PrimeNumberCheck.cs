

//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter a number from 1 to 100: ");
        number = Console.ReadLine();

        uint newNumber = uint.Parse(number);
        double n = Math.Sqrt(newNumber);

        bool result = true;
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                result = false;
                break;
            }
        }
        Console.WriteLine("The number is prime: {0}", result);
    }
}
