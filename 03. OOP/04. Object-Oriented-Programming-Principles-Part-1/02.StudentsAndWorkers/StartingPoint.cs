/*
Problem 2. Students and workers
• Define abstract class  Human  with a first name and a last name.
Define a new class  Student  which is derived from  Human  and has a new field –  grade .
Define class  Worker  derived from  Human  with a new property  WeekSalary  and  WorkHoursPerDay  and a method  MoneyPerHour()  
that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
• Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or  OrderBy()  extension method).
• Initialize a list of 10 workers and sort them by money per hour in descending order.
• Merge the lists and sort them by first name and last name.
*/
namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartingPoint
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho","Peshov",5),
                new Student("Ivan", "Georgiev", 2),
                new Student("Dragan", "Petkanov", 1),
                new Student("Ralica", "Rashkova", 2),
                new Student("Angel", "Angelov", 5),
                new Student("Katq", "Kirilova", 3),
                new Student("Iveta", "Iordanova", 1),
                new Student("Georgi","Dimitrov", 3),
                new Student("Vladimir", "Kolev", 4),
                new Student("Teodor", "Todorov", 4)
            };

            var sortedStudents = students.OrderBy(st => st.Grade)
                .Select(st => st);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine("{0} -> {1} grade", student.FirstName + " " + student.LastName, student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Kiro","Kirov",5, 8),
                new Worker("Petyr", "Petrov", 2,7),
                new Worker("Dimityr", "Ivanov", 1,5),
                new Worker("Georgi", "Kamenov", 2,4),
                new Worker("Kamen", "Nedqlkov", 5,1),
                new Worker("Vasko", "Vasilev", 3,2),
                new Worker("Kremena", "Ivanova", 1,3),
                new Worker("Vasilena","Vasielva", 3,8),
                new Worker("Iordan", "Ivanov", 4,8),
                new Worker("Misho", "Vasilev", 4,10)
            };

            var sortedWorkers = workers.OrderBy(w => w.MoneyPerHour())
                .Select(w => w);

            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine("Worker: {0}", worker.FirstName + " " + worker.LastName);
                Console.WriteLine("Money per hour: {0:F2}", worker.MoneyPerHour());
                Console.WriteLine();
            }

            List<dynamic> allPersons = new List<dynamic>(workers.Concat<dynamic>(students));

            Console.WriteLine("Sorting students and workers by name: ");

            var result = allPersons.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in result)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
