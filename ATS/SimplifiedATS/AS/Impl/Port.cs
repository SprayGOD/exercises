using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.AS.Impl
{
    public class Port : IPort
    {
        public PortState State { get; set; } = PortState.Unpluged;
        public event EventHandler<CallData> StateChanged;
        public event EventHandler<ConnectionResponse> CurrentConnectionChange;
        public void SubscribeForTerminalEventHandlers(ITerminal terminal)
        {
            terminal.OutgoingCall += CallStateChange;
            terminal.Response +=ResponseChangeState;
            terminal.CurrentConnection += OnCurrentConnectionChange;
        }

        public void CallStateChange(object sender, CallData callData)
        {
            State = PortState.Busy;
            StateChanged?.Invoke(this, callData);
        }

        public void ResponseChangeState(object sender, Response responce)
        {
            State = responce.State;
        }

        public void OnCurrentConnectionChange(object sender, ConnectionResponse connectionResponse)
        {
            CurrentConnectionChange?.Invoke(this, connectionResponse);
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
