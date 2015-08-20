/*
Problem 3. Read file contents
Write a program that enters file name along with its full file path (e.g.  C:\WINDOWS\win.ini ),
reads its contents and prints it on the console.
Find in MSDN how to use  System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/
using System;
using System.IO;
using System.Text;
class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter the file paht on your drive: ");
        string path = Console.ReadLine();

        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("There are invalid characters in the path, or no path has been entered!");
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("Path too long! Ensure that the paht length is less than 248 characters, or file name is less than 260 characters!");
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid directory!");
        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("Error opening the file");
            Console.WriteLine("Maybe: ");
            Console.WriteLine("1) You don't have permision to open the file!");
            Console.WriteLine("2) This operation is not supported in the current platform!");
            Console.WriteLine("3) The path, you have entered is not a name of a file, it is aname of a directory!");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("Invalid file format!");
        }
    }
}

