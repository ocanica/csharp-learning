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

            StandardMessages.InstructionMessage("first");
            output.FirstName = Console.ReadLine();

            StandardMessages.InstructionMessage("last");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
