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
        public event EventHandler<ConnectionResponse> CurrentConnection;
        public event EventHandler<Response> Response;

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
            OnCurrentConnection(ConnectionResponse.Drop);
        }

        public void Answer()
        {
            OnCurrentConnection(ConnectionResponse.Answer);
        }

        public void TurnOn()
        {
            OnTerminalStateChange(new Response(PortState.Free));
        }

        public void TurnOff()
        {
            OnTerminalStateChange(new Response(PortState.Unpluged));
        }


        private void OnOutgoingCall(CallData callData)
        {
            OutgoingCall?.Invoke(this, callData);
        }

        private void OnTerminalStateChange(Response response)
        {
            Response?.Invoke(this, response);
        }

        private void OnCurrentConnection(ConnectionResponse connectionResponse)
        {
            CurrentConnection?.Invoke(this, connectionResponse);
        }
    }
}
