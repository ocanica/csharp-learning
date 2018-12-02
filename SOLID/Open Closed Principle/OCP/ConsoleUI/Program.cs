using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Chris", LastName = "Martin"},
                new PersonModel { FirstName = "Laura", LastName = "Chambers"},
                new PersonModel { FirstName = "Erika", LastName = "Lawson"}
            };

            List<EmployeeModel> employee = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (PersonModel person in applicants)
            {
                employee.Add(accountProcessor.Create(person));
            }

            foreach (EmployeeModel emp in employee)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName } | { emp.EmailAddress } | { emp.EmployeeID }");
            }
        }
    }
}
