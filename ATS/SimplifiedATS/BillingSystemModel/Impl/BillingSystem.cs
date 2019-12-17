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
        public event EventHandler<CallData> StartCall;
        public event EventHandler<CallData> EndCall;

        public BillingSystem()
        {
            Tariffs = new List<ITariff>();
        }
        public int GetCallCost()
        {
            throw new NotImplementedException();
        }

        public void CallRecording(object sender, CallData callData)
        {
            
        }

        private void OnCallStart(object sender, CallData callData)
        {
            StartCall?.Invoke(sender, callData);
        }

        private void OnEndCall(object sender, CallData callData)
        {

        }
    }
}
