using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifiedATS.AS.Impl
{
    public class Agreement
    {
        public int AgreementNumber { get; }
        public string UserFirstName { get; }
        public string UserLastName { get; }
        public PhoneNumber Number { get; }

        public Agreement(User user, PhoneNumber number)
        {
            //ID
            UserFirstName = user.FirstName;
            UserLastName = user.LastName;
            Number = number;
        }
    }
}
