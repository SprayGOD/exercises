using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.SalesApp.Models;
using System.Data.Entity;

namespace DAL.SalesApp.Repositories
{
    public class ItemRepository : IRepository<Item>, IDisposable
    {
        private SalesContext _salesContext;

        public ItemRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Item item)
        {
            _salesContext.Items.Add(item);
        }

        public void Delete(int id)
        {
            Item item = _salesContext.Items.Find(id);
            if (item != null)
                _salesContext.Items.Remove(item);
        }

        public IEnumerable<Item> Find(Func<Item, bool> predicate)
        {
            return _salesContext.Items.Where(predicate).ToList();
        }

        public Item Get(int id)
        {
            return _salesContext.Items.Find(id);
        }

        public IEnumerable<Item> GetAll()
        {
            return _salesContext.Items;
        }

        public void Update(Item item)
        {
            _salesContext.Entry(item).State = EntityState.Modified;
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
