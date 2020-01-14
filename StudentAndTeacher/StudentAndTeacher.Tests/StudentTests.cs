using System;
using StudentAndTeacher;
using Xunit;

namespace StudentAndTeacher.Tests
{
    public class StudentTests
    {
        [Fact]
        public void StudentReturnsAge()
        {
            Student student = new Student();
            student.SetAge(21);

            Assert.Equal(21, student.Age);
        }

        [Fact]
        public void StudentReturnsGreeting()
        {
            Student Jill = new Student();
            Jill.SetName("Jill");

            Assert.Equal("Jill", Jill.Name);
        }
    }
}
