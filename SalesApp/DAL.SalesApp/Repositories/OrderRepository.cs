using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.SalesApp.Models;
using System.Data.Entity;

namespace DAL.SalesApp.Repositories
{
    public class OrderRepository : IRepository<Order>, IDisposable
    {
        private SalesContext _salesContext;

        public OrderRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Order order)
        {
            _salesContext.Orders.Add(order);
        }

        public void Delete(int id)
        {
            Order order = _salesContext.Orders.Find(id);
            if (order != null)
                _salesContext.Orders.Remove(order);
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

        public void Save()
        {
            _salesContext.SaveChanges();
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ClientRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
