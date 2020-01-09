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
        IRepository<Order> _orderRepository;

        public OrderService(string connectionString)
        {
            _orderRepository = new OrderRepository(connectionString);
        }

        public void MakeOrder(OrderDTO orderDto)
        {
            if(orderDto != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDTO, Order>());
                IMapper mapper = config.CreateMapper();

                _orderRepository.Create(mapper.Map<OrderDTO,Order>(orderDto));
            }
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
    }
}
