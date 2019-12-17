using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifiedATS.AS.Impl
{
    public struct PhoneNumber
    {
        public string Number { get; set; }

        public PhoneNumber(string number)
        {
            Number = number;
        }
    }
}
