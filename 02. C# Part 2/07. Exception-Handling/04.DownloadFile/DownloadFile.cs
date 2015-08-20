/*
Problem 4. Download file
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
• Find in Google how to download files in C#.
• Be sure to catch all exceptions and to free any used resources in the finally block.
*/
using System;
using System.Net;
class DownloadFile
{
    static void Main()
    {
        WebClient file = new WebClient();

        Console.Write("Enter URL to the file: ");
        string URL = Console.ReadLine();

        Console.Write("Enter directory to store the file: ");
        string directory = Console.ReadLine();

        try
        {
            file.DownloadFile(URL, directory);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Not URL has been entered!");
        }
        catch (WebException)
        {
            Console.WriteLine("One of these errors has been found: ");
            Console.WriteLine("1) Invalid URL!");
            Console.WriteLine("2) Not a filename has been entered!");
            Console.WriteLine("3) The file does not exist!");
            Console.WriteLine("4) An error occurred while downloading data");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Not supported operation!");
        }
    }
}

