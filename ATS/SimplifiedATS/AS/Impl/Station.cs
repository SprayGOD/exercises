using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS;
using SimplifiedATS.BillingSystemModel;
using SimplifiedATS.BillingSystemModel.Impl;
using SimplifiedATS.AS.States;
using SimplifiedATS.Helpers;
using SimplifiedATS.AS;

namespace SimplifiedATS.AS.Impl
{
    public class Station
    {
        private int _userID = 0;
        private int _baseNumber = 1000000;
        private IList<Agreement> _agreements;
        private IDictionary<PhoneNumber, IPort> _portsMap;
        private IList<IPort> _ports;
        private IList<ITerminal> _terminals;
        private BillingSystem _billingSystem;

        public Station()
        {
            _agreements = new List<Agreement>();
            _portsMap = new Dictionary<PhoneNumber, IPort>();
            _ports = new List<IPort>();
            _terminals = new List<ITerminal>();
            _billingSystem = new BillingSystem();
        }

        public void CreateAgreement(User user)
        {
            _userID++;
            PhoneNumber number = new PhoneNumber((_userID + _baseNumber).ToString());
            IPort port = new Port();
            port.State = PortState.Free;
            ITerminal terminal = new Terminal(number);
            user.Terminal = terminal;
            _agreements.Add(new Agreement(user, number));
            _portsMap.Add(number, port);
            _ports.Add(port);
            _terminals.Add(terminal);
            port.SubscribeForTerminalEventHandlers(terminal);
            SubscribeForPortEventHanlder(port);

        }

        public void SubscribeForPortEventHanlder(IPort port)
        {
            port.StateChanged += TryToCall;
            port.CurrentConnectionChange += ChangeCallState;
        }

        public void TryToCall(object sender, CallData callData)
        {
            if(_portsMap.ContainsKey(callData.Target))
            {
                IPort targetPort;
                _portsMap.TryGetValue(callData.Target, out targetPort);
                if(targetPort.State == PortState.Free)
                {
                    targetPort.State = PortState.Busy;
                    IPort sourcePort;
                    _portsMap.TryGetValue(callData.Source, out sourcePort);
                    //sourcePort.State = PortState.Busy;
                    _billingSystem.CallRecording(this, callData);
                }
                else
                {
                    Console.WriteLine("This number is busy right now or you need to cancel your call.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("This number does not exist.");
            }
        }

        public void ChangeCallState(object sender, ConnectionResponse connectionResponse)
        {

        }

        public event EventHandler<CallData> EstablishConnection;
        


    }
}
