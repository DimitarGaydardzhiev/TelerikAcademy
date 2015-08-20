/*
Problem 4. Print a Deck of 52 Cards 
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 
◦ The card faces should start from 2 to A.
◦ Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
*/

using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] suit =new string[]{"spades", "clubs", "hearts", "diamonds"} ;

        for (int i = 2; i <= 14; i++)
        {
                switch (i)
                {
                    case 2: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 3: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 4: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 5: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 6: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 7: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 8: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 9: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of, {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 10: Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 11: Console.WriteLine("J of {0}, J of {1}, J of {2}, J of,{3}", suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 12: Console.WriteLine("Q of {0}, Q of {1}, Q of {2}, Q of {3}", suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 13: Console.WriteLine("K of {0}, K of {1}, K of {2}, K of {3}", suit[0], suit[1], suit[2], suit[3]);
                        break;

                    case 14: Console.WriteLine("A of {0}, A of {1}, A of {2}, A of {3}", suit[0], suit[1], suit[2], suit[3]);
                        break;
            }
        }
    }
}

