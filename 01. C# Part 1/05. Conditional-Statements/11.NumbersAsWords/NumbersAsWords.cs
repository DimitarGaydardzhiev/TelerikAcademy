
//Problem 11. Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Please, enter number in range [0...999]: ");
        int number = int.Parse(Console.ReadLine());

        int b;

        string[] digit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] special = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] round = { " ", " ", "twenty", "thirty", "fourthy", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };

        if (number >= 0 && number <= 9)
        {
            for (int i = number; i < digit.Length; i += 10)
            {
                Console.WriteLine(digit[i]);
            }
        }
        else if (number >= 10 && number < 20)
        {
            for (int i = number % 10; i < special.Length; i += 20)
            {
                Console.WriteLine(special[i]);
            }
        }
        else if (number >= 20 && number <= 100 && number % 10 == 0)
        {
            for (int i = number / 10; i < round.Length; i += 20)
            {
                Console.WriteLine(round[i]);
            }
        }
        else if (number > 20 && number < 30)
        {
            for (int i = number % 20; i < digit.Length; i += 20)
            {
                Console.WriteLine("twenty {0}", digit[i]);
            }
        }
        else if (number > 30 && number < 40)
        {
            for (int i = number % 30; i < digit.Length; i += 20)
            {
                Console.WriteLine("thirty {0}", digit[i]);
            }
        }
        else if (number > 40 && number < 50)
        {
            for (int i = number % 40; i < digit.Length; i += 20)
            {
                Console.WriteLine("fourty {0}", digit[i]);
            }
        }
        else if (number > 50 && number < 60)
        {
            for (int i = number % 50; i < digit.Length; i += 20)
            {
                Console.WriteLine("fifty {0}", digit[i]);
            }
        }
        else if (number > 60 && number < 70)
        {
            for (int i = number % 60; i < digit.Length; i += 20)
            {
                Console.WriteLine("sixty {0}", digit[i]);
            }
        }
        else if (number > 70 && number < 80)
        {
            for (int i = number % 70; i < digit.Length; i += 20)
            {
                Console.WriteLine("seventy {0}", digit[i]);
            }
        }
        else if (number > 80 && number < 90)
        {
            for (int i = number % 80; i < digit.Length; i += 20)
            {
                Console.WriteLine("eighty {0}", digit[i]);
            }
        }
        else if (number > 90 && number < 100)
        {
            for (int i = number % 90; i < digit.Length; i += 20)
            {
                Console.WriteLine("ninety {0}", digit[i]);
            }
        }
        else if (number > 100 && number < 1000)
        {
            for (int j = number / 100; j < digit.Length; j += 10)
            {
                if (j >= 0 && j <= 9)
                {
                    Console.Write("{0} hundred ", digit[j]);
                }
                for (int i = number % 100; i <= 100; i += 100)
                {
                    if (i >= 1 && i <= 9)
                    {
                        Console.WriteLine("and {0}", digit[i]);
                    }
                    if (i >= 10 && i <= 19)
                    {
                        i %= 10;
                        Console.WriteLine("and {0}", special[i]);
                    }
                    if (i >= 20 && i < 100)
                    {
                        i /= 10;
                        Console.Write("and {0} ", round[i]);
                        if (number%10==0)
                        {
                            Console.WriteLine();
                        }
                        else if (((number % 100) % 10) != 0)
                        {
                            b = ((number % 100) % 10);
                            Console.WriteLine("{0}", digit[b]);
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Not a valid number!");
        }
    }
}


