using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            output.FirstName = Console.ReadLine();
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
