using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SalesApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public int Sum { get; set; }
    }
}
