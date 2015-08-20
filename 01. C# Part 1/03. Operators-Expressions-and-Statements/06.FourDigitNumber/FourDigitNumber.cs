

//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
//◦ Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
//◦ Puts the last digit in the first position:  dabc  (in our example  1201 ).
//◦ Exchanges the second and the third digits:  acbd  (in our example  2101 ).


//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        string number;
        Console.WriteLine("Enter number: ");
        number = Console.ReadLine();

        int newNumber = int.Parse(number);

        int firstDigit = newNumber / 1000;
        int secondDigit = (newNumber / 100) % 10;
        int thirdDigit = (newNumber / 10) % 10;
        int fourthDigit = newNumber % 10;

        if (firstDigit == 0)
        {
            Console.WriteLine("Please enter a number thet doesn't start with 0");
        }
        else
        {
            int sumDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("The sum of the digits in your number is: {0}", sumDigits);

            string sFirstNumber = firstDigit.ToString();
            string sSecondNumber = secondDigit.ToString();
            string sThirdNumber = thirdDigit.ToString();
            string sFourthNumber = fourthDigit.ToString();

            Console.WriteLine("Your number, in reversed order, lookes like this: {0}{1}{2}{3}", sFourthNumber, sThirdNumber, sSecondNumber, sFirstNumber);
            Console.WriteLine("When you change the last and the first digit, the result is: {0}{1}{2}{3}", sFourthNumber, sSecondNumber, sThirdNumber, sFirstNumber);
            Console.WriteLine("When you change the second and the third digit, the result is: {0}{1}{2}{3}", sFirstNumber, sThirdNumber, sSecondNumber, sFourthNumber);
        }
    }
}

