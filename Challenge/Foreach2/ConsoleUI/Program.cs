using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                people.Add(PersonDataCapture.Capture());
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"Hello, { person.FirstName } { person.LastName }");
            }
        }
    }
}
