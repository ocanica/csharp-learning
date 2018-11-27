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
            List<Person> people = getPersonModel();

            foreach (Person person in people)
            {
                Console.WriteLine($"Hello, { person.FirstName } {person.LastName}");
            }
        }

        static List<Person> getPersonModel()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = "Jeremy", LastName = "Vine" });
            output.Add(new Person { FirstName = "Charles", LastName = "Ocalot" });
            output.Add(new Person { FirstName = "Theo", LastName = "Glass" });
            output.Add(new Person { FirstName = "Chanel", LastName = "Thomas" });

            return output;
        }
    }
}
