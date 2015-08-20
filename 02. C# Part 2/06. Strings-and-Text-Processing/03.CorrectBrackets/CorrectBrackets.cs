/*
Problem 3. Correct brackets
Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression:  ((a+b)/5-d) . Example of incorrect expression:  )(a+b)) .
*/
using System;
class CorrectBrackets
{
    static bool CheckBreckets (string text)
    {
        int counterOpeningBreckets = 0;
        int counterClosingBreckets = 0;
        bool isCorrect = true;

        foreach (var symbol in text)
        {
            if (symbol == '(')
            {
                counterOpeningBreckets++;
            }
            if (symbol == ')')
            {
                counterClosingBreckets++;
            }
        }
        if (counterOpeningBreckets == counterClosingBreckets)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }

        return isCorrect;
    }
    static void Main()
    {
        Console.Write("Enter your expression: ");
        string expresion = Console.ReadLine();

        var result = CheckBreckets(expresion);

        Console.WriteLine("The expression is correct? => {0}", result);
    }
}

