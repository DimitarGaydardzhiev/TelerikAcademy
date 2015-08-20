/*
Problem 3. First before last
• Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
• Use LINQ query operators.
*/
namespace FirstBeforeLast
{
    using System;
    using Students;
    class MainProgram
    {
        static void Main()
        {
            Student[] students = new Student[5]
            {
                new Student("Ivan", "Draganov"),
                new Student("Pesho", "Asenov"),
                new Student("Dimitar", "Dimitrov"),
                new Student("Gosho", "Botev"),
                new Student("Kalin", "Malinov")
            };

            Student.SortNames(students);
        }
    }
}
