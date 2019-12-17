using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.AS
{
    public interface IPort
    {
        PortState State { get; set; } 
        event EventHandler<CallData> StateChanged;
        event EventHandler<ConnectionResponse> CurrentConnectionChange;

        void SubscribeForTerminalEventHandlers(ITerminal terminal);
    }
}
