using System;
using System.Collections.Generic;
using System.Text;

namespace UsernameAndPassword
{
    public class BaseUserModel
    {
        public string Name { get; set; }
        public Username Username { get; set; }
        public Password Password { get; set; }
    }
}
