using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Models;
using System.Data.Entity;

namespace SalesApp.DAL.Repositories
{
    public class OrderRepository : BaseRepository, IRepository<Order>
    {
        public OrderRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Order order)
        {
            _salesContext.Orders.Add(order);
            _salesContext.SaveChanges();
        }

        public IEnumerable<Order> Find(Func<Order, bool> predicate)
        {
            return _salesContext.Orders.Where(predicate).ToList();
        }

        public Order Get(int id)
        {
            return _salesContext.Orders.Find(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _salesContext.Orders;
        }

        public void Update(Order order)
        {
            _salesContext.Entry(order).State = EntityState.Modified;
        }
    }
}
