using System;

namespace UsernameAndPassword
{
    public class Username
    {
        public string username { get; set; }

        public Username SetUsername(string username)
        {
            var result = new Username();
            var usernameValidator = new Validators();

            if (usernameValidator.UsernameMinCharValidated(username))
            {
                this.username = username;
            }

            return result;
        }
    }
}
