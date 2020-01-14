using System;

namespace StudentAndTeacher
{
    public class Person
    {
        public int Age;
        public string Name;

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string Greeting()
        {
            return $"Hello, my name is {Name}";
        }
    }
}
