using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.AS
{
    public interface IPort
    {
        public PortState State { get; set; }
        public event EventHandler<CallData> StateChanged;
        public void SubscribeForTerminalEventHandlers(ITerminal terminal);

        public void ChangeState(object sender, CallData callData);

        public void ChangeState(object sender, Responce responce);

        public void StateChanging(object sender, CallData callData);

        public void OnStateChanged(CallData callData);
    }
}
