using System;
using System.Collections.Generic;
using System.Text;
using SimplifiedATS;
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

        public Station()
        {
            _agreements = new List<Agreement>();
            _portsMap = new Dictionary<PhoneNumber, IPort>();
            _ports = new List<IPort>();
            _terminals = new List<ITerminal>();
        }

        public void CreateAgreement(User user)
        {
            _userID++;
            PhoneNumber number = new PhoneNumber((_userID + _baseNumber).ToString());
            IPort port = new Port();
            ITerminal terminal = new Terminal(number);
            user.Terminal = terminal;
            _agreements.Add(new Agreement(user, number));
            _portsMap.Add(number, port);
            _ports.Add(port);
            _terminals.Add(terminal);
        }

        public void SubscribeForPortEventHanlder(Port port)
        {
            port.StateChanged += CheckPortAvailability;
        }

        public void CheckPortAvailability(object sender, CallData callData)
        {
            if(_portsMap.ContainsKey(callData.Target))
            {
                IPort port = new Port();
                _portsMap.TryGetValue(callData.Target, out port);
                if(port.State == PortState.Free)
                {

                }
            }
        }

        public event EventHandler<CallData> EstablishConnection;
        


    }
}
