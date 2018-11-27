using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class StandardMessages
    {
        public static void InstructionMessage(string field)
        {
            Console.WriteLine($"Please input you { field } name");
        }

        public static void OutputMessage(string field1, string field2)
        {
            Console.WriteLine($"Hello, { field1 } { field2 }");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }
    }
}
