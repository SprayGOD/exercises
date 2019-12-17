using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;
using SimplifiedATS.AS.States;

namespace SimplifiedATS.Helpers
{
    public struct Responce
    {
        public PortState State { get; set; }
        public PhoneNumber Source { get; set; }
    }
}
