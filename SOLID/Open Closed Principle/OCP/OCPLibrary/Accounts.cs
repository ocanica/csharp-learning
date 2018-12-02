using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@company.com";

            output.EmployeeID = $"{ person.FirstName.Substring(0, 1)}{ person.LastName.Substring(0, 3).ToUpperInvariant() }{ rnd.Next(1000, 9999) }";

            return output;
        }

        private static Random rnd = new Random();
    }
}
