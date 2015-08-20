namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentNullException(value, "School name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            if (this.Courses.Contains(course))
            {
                throw new InvalidOperationException("This school already contains this course");
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            if (!this.Courses.Contains(course))
            {
                throw new InvalidOperationException("This school doesnt contains this course");
            }

            this.Courses.Remove(course);
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("This school already contains this student");
            }

            if (this.Students.Any(st => st.Number == student.Number))
            {
                throw new InvalidOperationException("Student with this number has already been added");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException("This school doesnt contain such student");
            }

            this.Students.Remove(student);
        }
    }
}
