using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifiedATS.BillingSystemModel
{
    public interface ITariff
    {
        public int CostPerMinute { get; }
    }
}
