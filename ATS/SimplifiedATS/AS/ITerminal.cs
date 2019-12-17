using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;
using SimplifiedATS.AS.Impl;

namespace SimplifiedATS.AS
{
    public interface ITerminal
    {
        public PhoneNumber Number { get; }
        public event EventHandler<CallData> OutgoingCall;
        public event EventHandler<ConnectionResponse> CurrentConnection;
        public event EventHandler<Response> Response;

        public void Call(PhoneNumber number);

        public void EndCall();

        public void Answer();

        public void TurnOn();

        public void TurnOff();
    }
}
