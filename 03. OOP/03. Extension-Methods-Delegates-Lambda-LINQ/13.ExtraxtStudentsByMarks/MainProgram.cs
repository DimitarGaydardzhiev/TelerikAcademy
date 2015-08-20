﻿/*
Problem 13. Extract students by marks
• Select all students that have at least one mark  Excellent  ( 6 ) into a new anonymous class that has properties –  FullName  and  Marks .
• Use LINQ.
*/

namespace ExtraxtStudentsByMarks
{
    using System;
    using Students;
    using System.Collections.Generic;
    using StudentGroupsExtensions.Extensions;
    using System.Linq;
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Dimitar", "Dimitrov", 4356, "02/88456792", "abv@abv.bg", new List<int>{2, 3, 3, 4, 5}, 2),
                new Student("Ivan", "Draganov", 3649, "0859286974", "ghf@abv.bg", new List<int>{4,5,2,6,4}, 1),
                new Student("Pesho", "Malinov", 2345, "0897649876", "fd@abv.bg", new List<int>{2,4,5,3,2}, 2),
                new Student("Gosho", "Ivanov", 9087, "0887652097", "gf@abv.bg", new List<int>{4,2,3,6,2}, 3),
                new Student("Misho", "Petrov", 2141, "0876598734", "sad@abv.bg", new List<int>{3,5,2,4,5}, 4),
                new Student("Boian", "Todorov", 6709, "0089837482", "jhj@abv.bg", new List<int>{5,4,6,3,4}, 4)
            };

            var result = from student in students
                         where (student.Marks.Contains(6))
                         select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in result)
            {
                Console.Write("{0}, Marks: ", student.FullName);

                for (int i = 0; i < students.Count-1; i++)
                {
                    Console.Write(student.Marks[i] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
