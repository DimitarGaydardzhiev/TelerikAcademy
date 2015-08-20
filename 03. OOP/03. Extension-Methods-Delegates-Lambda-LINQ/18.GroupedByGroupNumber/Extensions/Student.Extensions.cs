

namespace StudentGroupsExtensions.Extensions
{
    using System;
	using Students;
	using System.Collections.Generic;
    using System.Linq;
    public static class ExtensionMethods
    {
		public static List<Student> SelectStudents(this List<Student> students, int groupNumber)
        {
            var result = students.Where(st => st.GroupNumber == groupNumber)
                .OrderBy(st => st.FirstName)
                .Select(st => st);

            return result.ToList();
        }

        public static List<Student> GetStudentsWith2FMarks(this List<Student> students, int mark)
        {
            var result = students.Where(st => st.Marks.Count(x => x == mark) == 2)
                .Select(st => st);

            return result.ToList();
        }
    }
}
