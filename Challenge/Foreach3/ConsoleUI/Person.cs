using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Person
    {

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
            }
        }

        private string _firstName;
        private string _lastName;
    }
}
