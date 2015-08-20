

//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal moneyAmmount = 1200.05M;
        string bankName = "OBB";
        string IBAN = "ABCDEFG56789FHJYTH";
        byte numberOfCards = 3;

        Console.WriteLine(" First Name: {0}\n Middle name: {1}\n Last Name: {2}\n Available ammount of money: {3}\n Bank name: {4}\n IBAN: {5}\n Number of credit cards: {6}",
                                 firstName, middleName, lastName, moneyAmmount, bankName, IBAN, numberOfCards);
    }
}

