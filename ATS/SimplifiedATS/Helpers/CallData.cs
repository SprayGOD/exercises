using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.AS.Impl;

namespace SimplifiedATS.Helpers
{
    public class CallData
    {
        public PhoneNumber Source { get; }
        public PhoneNumber Target { get; }
        public DateTime DateBegin { get; }

        public CallData(PhoneNumber source, PhoneNumber target)
        {
            Source = source;
            Target = target;
        }
    }
}
