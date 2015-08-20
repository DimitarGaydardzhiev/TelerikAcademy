/*
Problem 5. Order students
• Using the extension methods  OrderBy()  and  ThenBy()  with lambda expressions sort the students by first name and last name in descending order.
• Rewrite the same with LINQ.
*/
namespace OrderStudents
{
    using System;
    using Students;
    using System.Linq;
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

            Console.WriteLine("Sorted by first and last names: ");
            Student.SortByFirstAndLastName(students);
            Console.WriteLine();

            Console.WriteLine("Sorted by first and last names (with LINQ): ");
            Student.SortByFirstAndLastNameLINQ(students);
            Console.WriteLine();
        }
    }
}