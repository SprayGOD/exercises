using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;

namespace SimplifiedATS.AS
{
    public interface ITerminal
    {
        void Call(PhoneNumber number);
        void EndCall();
        void TurnOnOff();
    }
}
