/*
Problem 4. Age range
• Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/
namespace AgeRange
{
    using System;
    using Students;
    class MainProgram
    {
        static void Main()
        {
            Student[] students = new Student[5]
            {
                new Student("Ivan", "Draganov", 25),
                new Student("Pesho", "Asenov", 19),
                new Student("Dimitar", "Dimitrov", 18),
                new Student("Gosho", "Botev", 21),
                new Student("Kalin", "Malinov", 28)
            };

            Console.WriteLine("Sort by name: ");
            Student.SortNames(students);
            Console.WriteLine();

            Console.WriteLine("Sort by age: ");
            Student.SortByAge(students);
            Console.WriteLine();
        }
    }
}