using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.AS.Impl
{
    public class Port : IPort
    {
        public PortState State { get; set; }
        public event EventHandler<CallData> StateChanged;
        public void SubscribeForTerminalEventHandlers(ITerminal terminal)
        {
            terminal.OutgoingCall += ChangeState;
            terminal.IncomingCall += ChangeState;
        }

        public void ChangeState(object sender, CallData callData)
        {
            State = PortState.Free;
            StateChanged?.Invoke(this, callData);
        }

        public void ChangeState(object sender, Responce responce)
        {
            State = responce.State;
        }

        public void StateChanging(object sender,CallData callData)
        {
            OnStateChanged(callData);
        }

        public void OnStateChanged(CallData callData)
        {
            StateChanged?.Invoke(this, callData);
        }
    }
}
