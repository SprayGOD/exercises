using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS;

namespace SimplifiedATS
{
    public class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public ITerminal Terminal { get; set; }

        public User(string firstName, string lastName)       
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
