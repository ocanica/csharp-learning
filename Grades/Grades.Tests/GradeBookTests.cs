using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(45);

            GradeStatistics results = book.ComputeStatistics();

            Assert.AreEqual(95, results.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(45);

            GradeStatistics results = book.ComputeStatistics();

            Assert.AreEqual(45, results.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(44);
            book.AddGrade(13);

            GradeStatistics results = book.ComputeStatistics();

            Assert.AreEqual(50.66, results.AverageGrade, 0.01);
        }

        [TestMethod]
        public void ComputeLetterGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(100);
            book.AddGrade(100);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual("A", result.LetterGrade);
        }
    }
}
