using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];
            AddGrades(grades);

            Assert.AreEqual(79.5f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 79.5f;
        }


        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 11, 1);

            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "lloyd";
            name = name.ToUpperInvariant();

            Assert.AreEqual("LLOYD", name);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);

            Assert.AreEqual(book1.Name, "A GradeBook");
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Lloyd";
            string name2 = "lloyd";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 5;

            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Lloyd's Gradebook";

            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
