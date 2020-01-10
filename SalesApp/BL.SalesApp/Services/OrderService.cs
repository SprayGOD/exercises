using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Repositories;
using SalesApp.DAL.Models;
using SalesApp.BLL.DTO;
using AutoMapper;

namespace SalesApp.BLL.Services
{
    public class OrderService
    {
        private OrderRepository _orderRepository;
        private string _connectionString;

        public OrderService(string connectionString)
        {
            this._connectionString = connectionString;
            _orderRepository = new OrderRepository(connectionString);
        }

        public void MakeOrder(ClientDTO clientDTO, ItemDTO itemDTO, ManagerDTO managerDTO, int sum)
        {
            ClientService clientService = new ClientService(_connectionString);
            ItemService itemService = new ItemService(_connectionString);
            ManagerService managerService = new ManagerService(_connectionString);

            MakeUniqueClient(clientService, clientDTO);
            MakeUniqueItem(itemService, itemDTO);
            MakeUniqueManager(managerService, managerDTO);

            clientDTO = clientService.Find(x => x.Name == clientDTO.Name).First();
            itemDTO = itemService.Find(x => x.Name == itemDTO.Name).First();
            managerDTO = managerService.Find(x => x.SecondName == managerDTO.SecondName).First();

            Order order = new Order() { ClientId = clientDTO.Id, ItemId = itemDTO.Id, ManagerId = managerDTO.Id, Sum = sum };
            _orderRepository.Create(order);
        }

        public IEnumerable<OrderDTO> GetOrders()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Order>, List<OrderDTO>>(_orderRepository.GetAll());
        }

        public OrderDTO GetOrder(int id)
        {
            var order = _orderRepository.Get(id);
            if (order == null)
                throw new Exception("Order not found.");

            return new OrderDTO { Id = order.Id, ClientId = order.ClientId, ItemId = order.ItemId, ManagerId = order.ManagerId, Sum = order.Sum };
        }

        private void MakeUniqueClient(ClientService clientService, ClientDTO clientDTO)
        {
            if (clientDTO != null)
            {
                var tmp = clientService.Find(x => x.Name == clientDTO.Name);
                if (tmp.Count() == 0)
                {
                    clientService.MakeClient(clientDTO);
                }
            }
        }

        private void MakeUniqueItem(ItemService itemService, ItemDTO itemDTO)
        {
            if (itemDTO != null)
            {
                var tmp = itemService.Find(x => x.Name == itemDTO.Name);
                if (tmp.Count() == 0)
                {
                    itemService.MakeItem(itemDTO);
                }
            }
        }

        private void MakeUniqueManager(ManagerService managerService, ManagerDTO managerDTO)
        {
            if (managerDTO != null)
            {
                var tmp = managerService.Find(x => x.SecondName == managerDTO.SecondName);
                if (tmp.Count() == 0)
                {
                    managerService.MakeManager(managerDTO);
                }
            }
        }
    }
}
