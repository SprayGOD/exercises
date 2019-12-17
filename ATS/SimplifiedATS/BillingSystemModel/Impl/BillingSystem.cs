using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS.Helpers;

namespace SimplifiedATS.BillingSystemModel.Impl
{
    public class BillingSystem : IBillingSystem
    {
        public IList<ITariff> Tariffs { get; }
        protected IList<CallData> _callRecords;
        public event EventHandler<CallData> CallRecording;

        public BillingSystem()
        {
            Tariffs = new List<ITariff>();
        }
        public int GetCallCost()
        {
            throw new NotImplementedException();
        }

        public void CallStarted(object sender, CallData callData)
        {
            OnCallStarted(sender, callData);
        }

        protected void OnCallStarted(object sender, CallData callData)
        {
            CallRecording?.Invoke(sender, callData);
        }
    }
}
