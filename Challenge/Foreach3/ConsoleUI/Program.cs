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
            // Initial new list of people
            List<Person> people = new List<Person>();

            // Main method controls the flow of the program using the for loop
            for (int i = 0; i < 1; i++)
            {
                people.Add(PersonDataCapture.Capture());
            }

            // Iterate over the result printing the standard message
            foreach (Person person in people)
            {
                StandardMessages.OutputMessage(person.FirstName, person.LastName);
            }

            StandardMessages.EndApplication();
        }
    }
}
