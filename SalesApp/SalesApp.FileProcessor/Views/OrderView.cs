using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.FileProcessor.Views
{
    public class OrderView
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientView Client { get; set; }
        public int ItemId { get; set; }
        public ItemView Item { get; set; }
        public int ManagerId { get; set; }
        public ManagerView Manager { get; set; }
        public int Sum { get; set; }
    }
}
