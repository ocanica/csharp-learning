using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StudentAndTeacher.Tests
{
    public class PersonTests
    {
        [Fact]
        public void PersonHasGreeing()
        {
            Person jack = new Person();

            jack.SetName("Jack");

            string greeting = jack.Greeting();
            string expected = "Hello, my name is Jack";

            Assert.Equal(expected, jack.Greeting());
        }
    }
}
