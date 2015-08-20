//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, J, Q, K and A. Write a
//program that enteres a string and prints "yes" if it is a valid card sign or "no" otherwise.

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Please, enter card sign: ");
        string sign;
        sign = Console.ReadLine();

        string[] card = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        if (card[0].Contains(sign) || card[1].Contains(sign) || card[2].Contains(sign) || card[3].Contains(sign)
            || card[4].Contains(sign) || card[5].Contains(sign) || card[6].Contains(sign) || card[7].Contains(sign)
            || card[8].Contains(sign) || card[9].Contains(sign) || card[10].Contains(sign) || card[11].Contains(sign)
            || card[12].Contains(sign))
        {
            Console.WriteLine("Yes");
        }
        else
	    {
            Console.WriteLine("No");
	    }
        
    } 
}

