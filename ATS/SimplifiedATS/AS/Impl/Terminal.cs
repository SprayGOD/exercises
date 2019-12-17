using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.Helpers;
using SimplifiedATS.AS.States;

namespace SimplifiedATS.AS.Impl
{
    public class Terminal : ITerminal
    {
        public PhoneNumber Number { get; }
        public event EventHandler<CallData> OutgoingCall;
        public event EventHandler<Responce> IncomingCall;

        public Terminal(PhoneNumber number)
        {
            Number = number;
        }

        public void Call(PhoneNumber number)
        {
            OnOutgoingCall(new CallData(Number, number));
        }

        public void EndCall()
        {
            throw new NotImplementedException();
        }

        public void Answer(Responce responce)
        {
            OnIncomingCall(responce);
        }

        public void TurnOnOff()
        {
            throw new NotImplementedException();
        }

        private void OnOutgoingCall(CallData callData)
        {
            OutgoingCall?.Invoke(this, callData);
        }

        private void OnIncomingCall(Responce responce)
        {
            IncomingCall?.Invoke(this, responce);
        }
    }
}
