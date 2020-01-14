using System;
using System.Collections.Generic;
using System.Text;

namespace UsernameAndPassword
{
    public class Password
    {
        public string password { get; set; }
        private bool passwordLenghtCheck = false;
        private bool passwordInclNumberCheck = false;

        public void SetPassword(string password)
        {
            var passwordValidtor = new Validators();

            if (passwordValidtor.PasswordMinCharValidated(password))
                passwordLenghtCheck = true;
            if (passwordValidtor.PasswordIncludesNumberValidated(password))
                passwordInclNumberCheck = true;

            if (passwordLenghtCheck && passwordInclNumberCheck)
                this.password = password;
        }
    }
}
