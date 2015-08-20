/*
Problem 4. Person class
• Create a class  Person  with two fields – name and age. 
Age can be left unspecified (may contain  null  value. Override  ToString()  to display the information of a person and if age is not specified – to say so.
• Write a program to test this functionality.
*/
namespace PersonClass
{
    using System;
    public class StartingPoint
    {
        public static void Main()
        {
            Person person = new Person("Pesho");
            Console.WriteLine(person.ToString());

            Person secondPerson = new Person("Gosho", 25);
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
