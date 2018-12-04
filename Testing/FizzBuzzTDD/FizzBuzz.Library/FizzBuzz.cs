using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzz
    {
        public static string GetValue(int input)
        {
            /* Test 1
            if (input == 3)
                return "Fizz";
            */

            /* Test 2
            if (input == 5)
                return "Buzz";
            */

            /* Test 3
            if (input % 3 == 0)
                return "Fizz";
            */

            /* Test 4
            if (input % 5 == 0)
                return "Buzz";
            */

            /* Test 5
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)
                return "Fizz";
            if(input % 5 == 0)
                return "Buzz";
            */

            // Test 6 [Refactor] 
            string output = string.Empty;
            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();

            return output;
        }
    }
}
