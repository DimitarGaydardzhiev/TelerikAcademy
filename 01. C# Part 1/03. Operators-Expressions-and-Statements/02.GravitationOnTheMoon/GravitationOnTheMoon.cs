
//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately  17%  of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        string earthWeight;
        Console.Write("Enter your weight in kg: ");
        earthWeight = Console.ReadLine();

        double weight = double.Parse(earthWeight);

        double moonWeight;
        moonWeight = Math.Abs((0.17 * weight) - weight);

        Console.WriteLine("Your weight on the moon will be: {0} kg", moonWeight);
    }
}