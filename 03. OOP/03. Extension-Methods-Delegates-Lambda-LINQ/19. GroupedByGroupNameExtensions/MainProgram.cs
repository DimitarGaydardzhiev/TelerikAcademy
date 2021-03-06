﻿/*
Problem 19. Grouped by GroupName extensions
• Rewrite the previous using extension methods.
*/

namespace GroupedByGroupNameExtensions
{
    using System;
    using Students;
    using StudentGroupsExtensions;
    using System.Collections.Generic;
    using StudentGroupsExtensions.Extensions;
    using System.Linq;
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Dimitar", "Dimitrov", 435606, "02/88456792", "abv@abv.bg", new List<int>{2, 3, 3, 4, 5}, 2),
                new Student("Ivan", "Draganov", 364907, "0859286974", "ghf@abv.bg", new List<int>{4,5,2,6,4}, 1),
                new Student("Pesho", "Malinov", 234506, "0897649876", "fd@abv.bg", new List<int>{2,4,5,3,2}, 2),
                new Student("Gosho", "Ivanov", 908708, "0887652097", "gf@abv.bg", new List<int>{4,2,3,6,2}, 3),
                new Student("Misho", "Petrov", 214106, "0876598734", "sad@abv.bg", new List<int>{3,5,2,4,5}, 4),
                new Student("Boian", "Todorov", 670911, "0089837482", "jhj@abv.bg", new List<int>{5,4,6,3,4}, 4)
            };

            var result = students.GroupStudents();

            foreach (Student student in result)
            {
                Console.WriteLine("{0} -> {1} group", student.FirstName + " " + student.LastName, student.GroupNumber);
            }
        }
    }
}
