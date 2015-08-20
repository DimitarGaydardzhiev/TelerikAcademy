

//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter manager names: ");
        string names = Console.ReadLine();

        Console.Write("Please enter company name: ");
        string company = Console.ReadLine();

        Console.Write("Please enter address: ");
        string address = Console.ReadLine();

        Console.Write("Please enter phone number: ");
        string phone = Console.ReadLine();

        Console.Write("Please enter fax number: ");
        string fax = Console.ReadLine();

        Console.Write("Please enter Web Site number: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("COMPANY INFORMATION:\n\nManager: {0}\nCompany name: {1}\nAdress: {2}\nPhone Number: {3}\nFax number: {4}\nweb site: {5}", names, company, address, phone, fax, webSite);

    }
}