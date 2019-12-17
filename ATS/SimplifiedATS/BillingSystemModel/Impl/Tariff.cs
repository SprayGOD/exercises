using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifiedATS.BillingSystemModel.Impl
{
    public class Tariff : ITariff
    {
        public int CostPerMinute { get; } = 2;
    }
}
