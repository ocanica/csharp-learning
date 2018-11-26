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
            List<string> people = getNames();

            foreach (string person in people)
            {
                Console.WriteLine($"Hello, { person }");
            }

            Console.ReadLine();

            List<PersonModel> personModels = getPersonModels();

            foreach (PersonModel person in personModels)
            {
                Console.WriteLine($"Hello, { person.FirstName } { person.LastName } ");
            }

        }

        private static List<PersonModel> getPersonModels()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Mark", LastName = "James" });
            output.Add(new PersonModel { FirstName = "Jenny", LastName = "Hammond" });

            return output;
        }

        private static List<string> getNames()
        {
            List<string> output = new List<string>();

            output.Add("Ricky");
            output.Add("Mark");

            return output;
        }
    }
}
