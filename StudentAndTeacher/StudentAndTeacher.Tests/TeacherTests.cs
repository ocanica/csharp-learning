using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StudentAndTeacher.Tests
{
    public class TeacherTests
    {
        [Fact]
        public void TeacherReturnsName()
        {
            Teacher Erika = new Teacher();
            Erika.SetName("Erika");
            string expected = $"Hello, my name is Erika";

            Assert.Equal(expected, Erika.Greeting());
        }

        [Fact]
        public void TeacherReturnsExplain()
        {
            Teacher teacher = new Teacher();
            string expected = "Explanation begins";

            Assert.Equal(expected, teacher.Explain());
        }
    }
}
