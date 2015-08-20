
//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. 
//◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please enter what variable do you want to use. Use '1' for int, '2' for double and '3' for string: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.WriteLine("Please, enter number: ");
                int inputInt = int.Parse(Console.ReadLine());
                inputInt++;
                Console.WriteLine(inputInt);
                break;
                
            case "2": Console.WriteLine("Please, enter number: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble++;
                Console.WriteLine(inputDouble);
                break;

            case "3": Console.WriteLine("Please, enter string: ");
                string inputStr = Console.ReadLine();
                Console.WriteLine("{0}*", inputStr);
                break;

            default: Console.WriteLine("Not a valid input!");
                break;
        }

        //if (choice=="1"||choice=="2")
        //{
        //    Console.Write("Please enter number: ");
        //    int input = int.Parse(Console.ReadLine());
        //    input++;
        //    Console.WriteLine(input);
        //}
        //if (choice == "3")
        //{
        //    Console.Write("Please enter string: ");
        //    string str = Console.ReadLine();
        //    Console.WriteLine("{0}*", str);
        //}
    }
}

