/*
Problem 6. binary to hexadecimal
Write a program to convert binary numbers to hexadecimal numbers (directly).
*/
using System;
using System.Collections.Generic;
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please, enter binary number N = ");
        string binaryNumber = Console.ReadLine();

        int strLength = binaryNumber.Length;
        List<string> result = new List<string>();

        Console.Write("The number {0} in hexidecimal numeric system is: ", binaryNumber);

        for (int i = 0; i < binaryNumber.Length; i+=4)
        {
            string currentElement = binaryNumber.Substring(i,4);

            if (currentElement == "1010")
            {
                Console.Write("A");
            }
            if (currentElement == "1011")
            {
                Console.Write("B");
            }
            if (currentElement == "1100")
            {
                Console.Write("C");
            }
            if (currentElement == "1101")
            {
                Console.Write("D");
            }
            if (currentElement == "1110")
            {
                Console.Write("E");
            }
            if (currentElement == "1111")
            {
                Console.Write("F");
            }
            if (currentElement == "0000")
            {
                Console.Write("0");
            }
            if (currentElement == "0001")
            {
                Console.Write("1");
            }
            if (currentElement == "0010")
            {
                Console.Write("2");
            }
            if (currentElement == "0011")
            {
                Console.Write("3");
            }
            if (currentElement == "0100")
            {
                Console.Write("4");
            }
            if (currentElement == "0101")
            {
                Console.Write("5");
            }
            if (currentElement == "0110")
            {
                Console.Write("6");
            }
            if (currentElement == "0111")
            {
                Console.Write("7");
            }
            if (currentElement == "1000")
            {
                Console.Write("8");
            }
            if (currentElement == "1001")
            {
                Console.Write("9");
            }
        }
        Console.WriteLine();
    }
}

