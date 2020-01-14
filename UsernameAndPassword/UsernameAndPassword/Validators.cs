using System;
using System.Collections.Generic;
using System.Text;

namespace UsernameAndPassword
{
    public class Validators
    {
        public bool UsernameMinCharValidated(string username)
        {
            if (username.Length >= 5)
                return true;
            return false;
        }

        public bool PasswordMinCharValidated(string password)
        {
            if (password.Length >= 6)
                return true;
            return false;
        }

        public bool PasswordIncludesNumberValidated(string password)
        {
            var numbersCharArr = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            var passwordCharList = new List<char>();
            var found = false;

            foreach(char character in password)
            {
                passwordCharList.Add(character);
            }

            foreach(char number in numbersCharArr)
            {
                if (passwordCharList.Contains(number))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
    }
}
