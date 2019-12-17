using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.AS.Impl
{
    public class Terminal : ITerminal
    {
        public PhoneNumber Number { get; }
        public event EventHandler<CallData> OutgoingCall;

        public Terminal(PhoneNumber number)
        {
            Number = number;
        }

        public void Call(PhoneNumber number)
        {
            OnOutgoingCall(this, new CallData(Number, number));
        }

        public void EndCall()
        {
            throw new NotImplementedException();
        }

        public void TurnOnOff()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnOutgoingCall(object sender, CallData callData)
        {
            OutgoingCall?.Invoke(this, callData);
        }
    }
}
