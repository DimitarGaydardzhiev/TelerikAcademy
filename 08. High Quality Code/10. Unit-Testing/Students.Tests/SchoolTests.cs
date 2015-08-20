namespace Students.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowAnException()
        {
            var school = new School("UACEG");
        }

        [TestMethod]
        public void SchoolShouldReturnCorectName()
        {
            var school = new School("UACEG");
            Assert.AreEqual("UACEG", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowAnExceptionIfNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowAnExceptionIfNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddedCourseShouldNotBeNull()
        {
            var school = new School("Telerik");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NewCourseToAddShouldThrownAnExceptionIfAlreadyExists()
        {
            var school = new School("Telerik");
            var course = new Course("Math");

            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void RemovedCourseShouldNotBeNull()
        {
            var school = new School("Telerik");
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void RemovedCourseShouldBeContainedInTheSchool()
        {
            var school = new School("Telerik");
            var course = new Course("Math");

            school.RemoveCourse(course);
        }

        [TestMethod]

        public void SchoolShouldAddCourseCorectly()
        {
            var school = new School("Telerik");
            var course = new Course("Math");

            school.AddCourse(course);

            Assert.AreEqual(course, school.Courses.First());
        }

        [TestMethod]
        public void SchoolShouldAddStudentCorectly()
        {
            var school = new School("Telerik");
            var student = new Student("Gosho", 50000);

            school.AddStudent(student);

            Assert.AreEqual(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void AddedStudentShouldNotBeNull()
        {
            var school = new School("Telerik");

            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void SchoolShouldThrownAnExceptionWhenAddedStudentAlreadyExists()
        {
            var school = new School("Telerik");
            var student = new Student("Gosho", 50000);

            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void SchoolShouldThrownAnExceptionWhenAddingStudentsWithTheSameId()
        {
            var school = new School("Telerik");
            var student = new Student("Gosho", 50000);
            var anotherStudent = new Student("Pesho", 50000);

            school.AddStudent(student);
            school.AddStudent(anotherStudent);
        }

        [TestMethod]
        public void SchoolShouldRemoveStudentCorectly()
        {
            var school = new School("Telerik");
            var student = new Student("Gosho", 50000);

            school.AddStudent(student);
            school.RemoveStudent(student);

            Assert.IsTrue(school.Students.Count == 0);
        }

        [TestMethod]
        public void SchoolShouldRemoveCourseCorectly()
        {
            var school = new School("Telerik");
            var course = new Course("HTML");

            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void SchoolShouldThrownWhenRemovingNullStudent()
        {
            var school = new School("Telerik");

            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void SchoolShouldThrownWhenRemovingStudentDoesntExist()
        {
            var school = new School("Telerik");
            var student = new Student("Gosho", 50000);

            school.RemoveStudent(student);
        }
    }
}
