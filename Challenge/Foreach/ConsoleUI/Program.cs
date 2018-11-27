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
            List<string> peopleNames = getPeopleNames();

            foreach (string personName in peopleNames)
            {
                Console.WriteLine($"Hello, { personName }");
            }
        }

        static List<string> getPeopleNames()
        {
            List<string> output = new List<string>();

            output.Add("Kevin");
            output.Add("Mark");
            output.Add("Chris");
            output.Add("Gemma");
            output.Add("Michael");
            output.Add("Alexandra");

            return output;
        }
    }
}
