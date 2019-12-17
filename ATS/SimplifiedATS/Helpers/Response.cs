using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;
using SimplifiedATS.AS.States;

namespace SimplifiedATS.Helpers
{
    public struct Response
    {
        public PortState State { get; set; }
        public PhoneNumber Source { get; set; }

        public Response(PortState state, PhoneNumber source)
        {
            State = state;
            Source = source;
        }

        public Response(PortState state)
        {
            State = state;
            Source = new PhoneNumber("");
        }
    }
}
