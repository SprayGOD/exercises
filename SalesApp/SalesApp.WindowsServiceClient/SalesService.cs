using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.WindowsServiceClient
{
    public partial class SalesService : ServiceBase
    {
        //SalesInfoProcessor salesInfoProcessor = new SalesInfoProcessor();
        public SalesService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //salesInfoProcessor.Start();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
