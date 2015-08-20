

//Problem 14. Modify a Bit at Given Position
//We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
//Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  at the position  p  from the binary representation of  n  while preserving all other bits in  n .

using System;

class ModifyBit
{
    static void Main()
    {
        {
            string number;
            Console.WriteLine("Enter number:");
            number = Console.ReadLine();

            string value;
            Console.WriteLine("Enter value:");
            value = Console.ReadLine();

            string position;
            Console.WriteLine("Enter bit position:");
            position = Console.ReadLine();

            int n = int.Parse(number);
            int v = int.Parse(value);
            int p = int.Parse(position);

            if (v == 1)
            {
                int mask = 1 << p;
                int result = mask | n;
                Console.WriteLine(result);
            }
            else
            {
                int mask = ~(1 << p);
                int result = mask & n;
                Console.WriteLine(result);
            }

        }
    }
}
