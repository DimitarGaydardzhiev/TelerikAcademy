﻿//Problem 2. Write a program that applies bonus score to given score in the range [1...9] by the following rules:
//1. If the score is between 1 and 3 the program multiplies it by 10.
//2. If the score is between 4 and 6 the program multiplies it by 100.
//3. If the score is between 7 and 9 the program multiplies it by 1000.
//4. If the score is 0 or more than 9 the program points "invalid score".

using System;
class BonusScore
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 1 && score <= 3)
        {
            int firstFinalScore = score * 10;
            Console.WriteLine("Your final score is: {0}", firstFinalScore);
        }
        else if (score >= 4 && score <= 6)
        {
            int secondFinalScore = score * 100;
            Console.WriteLine("Your final score is: {0}", secondFinalScore);
        }
        else if (score >= 7 && score <= 9)
        {
            int thirdFinalScore = score * 1000;
            Console.WriteLine("Your final score is: {0}", thirdFinalScore);
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

