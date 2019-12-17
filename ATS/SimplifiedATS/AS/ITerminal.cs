using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.Helpers;
using SimplifiedATS.AS.Impl;

namespace SimplifiedATS.AS
{
    public interface ITerminal
    {
        public event EventHandler<CallData> OutgoingCall;
        public event EventHandler<Responce> IncomingCall;

        void Call(PhoneNumber number);
        void EndCall();
        void TurnOnOff();
    }
}
