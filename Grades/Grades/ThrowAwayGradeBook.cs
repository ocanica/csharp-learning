using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;

            foreach (float grade in grades)
            {
                if (grade < lowest)
                    lowest = grade;
            }

            return base.ComputeStatistics();
        }
    }
}
