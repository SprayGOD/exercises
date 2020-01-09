using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int ManagerId { get; set; }
        public ManagerDTO Manager { get; set; }
        public int Sum { get; set; }
    }
}
