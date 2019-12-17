using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;
using SimplifiedATS.AS.States;

namespace SimplifiedATS.Helpers
{
    public struct Responce
    {
        public PortState state { get; set; }
        public PhoneNumber source { get; set; }
    }
}
