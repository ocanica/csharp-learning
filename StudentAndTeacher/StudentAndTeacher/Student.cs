using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAndTeacher
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class!");
        }

        public string ShowAge()
        {
            return $"My age is: {Age} years old";
        }
    }
}
