/*
Problem 2. Enter numbers
Write a method  ReadNumber(int start, int end)  that enters an integer number in a given range [ start…end ]. 
◦ If an invalid number or non-number text is entered, the method should throw an exception.
• Using this method write a program that enters  10  numbers:  a1, a2, … a10 , such that  1 < a1 < … < a10 < 100  
*/
using System;
class EnterNumbers
{
    static void ReadNumber()
    {
        Console.Write("Enter range (bigger than 10 numbers) in format a:b: ");
        string range = Console.ReadLine();

        int start = new int();
        int end = new int();
        int number = new int();
        int currentNumber = int.MinValue;

        try
        {
            string[] splitRange = range.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            start = int.Parse(splitRange[0]);
            end = int.Parse(splitRange[1]);

            if ((end - start) < 11)
            {
                throw new Exception();
            }
            else
            {
                try
                {
                    Console.Write("Enter 10 numbers in the range {0}:{1} => ", start, end);

                    for (int i = 0; i < 10; i++)
                    {
                        number = int.Parse(Console.ReadLine());
                        if (number < currentNumber || number < start || number > end)
                        {
                            throw new Exception();
                        }
                        currentNumber = number;
                    }

                    if (number < start || number > end)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Range!");
        }
    }
    static void Main()
    {
        ReadNumber();
    }
}
