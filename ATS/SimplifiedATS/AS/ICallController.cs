using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;

namespace SimplifiedATS.AS
{
    interface ICallController
    {
        event EventHandler<PhoneNumber> CallListener;
    }
}
