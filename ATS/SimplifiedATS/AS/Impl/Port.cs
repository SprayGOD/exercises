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
        
        public void RegisterForTerminalEventHandlers(Terminal terminal)
        {
            terminal.
        }
    }
}
