namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsNumbers = 30;
        private ICollection<Student> students;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.Students.Count + 1 > MaxStudentsNumbers)
            {
                throw new InvalidOperationException(string.Format("Students in a course cannot be more than {0}", MaxStudentsNumbers));
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("This course already contains this student");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            this.Students.Remove(student);
        }
    }
}
