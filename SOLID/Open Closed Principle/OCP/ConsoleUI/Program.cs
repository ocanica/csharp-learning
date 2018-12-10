using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP.Library;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "James", LastName = "Watt"},
                new PersonModel { FirstName = "Alexandra", LastName = "Flemming"},
                new PersonModel { FirstName = "Deborah", LastName = "Louis"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (PersonModel person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (EmployeeModel employee in employees)
            {
                Console.WriteLine($"{ employee.FirstName } { employee.LastName }: { employee.EmailAddress } IsManager: { (employee.IsManager ? "Yes" : "No") }");
            }

        }
    }
}
