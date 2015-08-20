namespace Students.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void ShouldCreateCourseWithoutThrowinAnException()
        {
            var course = new Course("Java");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowWhenCourseWithNullNameIsCreated()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void ExpectedToReturnCorrectCourseName()
        {
            var course = new Course("HQC");
            Assert.AreEqual("HQC", course.Name);
        }

        [TestMethod]
        public void ExpectToAddStudentCorrectly()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 55555);

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectToThrowWhenStudentNameIsNullOrEmpty()
        {
            var course = new Course("C#");
            var student = new Student(string.Empty, 55555);

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void ExpectedToThrowWhenNumbersOfStudentInTheCourseAreMoreThanMax()
        {
            var course = new Course("C#");
            var number = 50000;

            for (int i = 0; i < 31; i++)
            {
                var student = new Student("Pesho", number + i);
                course.AddStudent(student);
            }

            Assert.IsTrue(course.Students.Count > 30);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExpectedToThrowWhenAddingSameStudentToCourse()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 55555);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        public void ExpectedToRemoveStudentFromTheCourseCorrectly()
        {
            var course = new Course("C#2");
            var student = new Student("Mario", 77777);

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.IsTrue(course.Students.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectedToThrowWhenRemovingNullStudent()
        {
            var course = new Course("C#");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectedToThrowWhenAddingNullStudent()
        {
            var course = new Course("C#");
            course.AddStudent(null);
        }
    }
}
