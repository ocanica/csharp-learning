using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Library.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_When1_Returns1()
        {
            // Arrange
            int input = 1;
            // Act
            string output = FizzBuzz.GetValue(input);
            // Assert
            Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void FizzBuzz_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("2", output);
        }

        [TestMethod]
        public void FizzBuzz_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void FizzBuzz_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void FizzBuzz_When6_ReturnFizz()
        {
            int input = 6;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void FizzBuzz_When9_ReturnsFizz()
        {
            int input = 9;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void FizzBuzz_When10_ReturnsBuzz()
        {
            int input = 10;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void FizzBuzz_When15_ReturnsFizzBuzz()
        {
            int input = 15;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
