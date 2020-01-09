using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.SalesApp.Models;
using System.Data.Entity;

namespace DAL.SalesApp.Repositories
{
    public class ClientRepository : IRepository<Client>, IDisposable
    {
        private SalesContext _salesContext;

        public ClientRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Client client)
        {
            _salesContext.Clients.Add(client);
        }

        public void Delete(int id)
        {
            Client client = _salesContext.Clients.Find(id);
            if (client != null)
                _salesContext.Clients.Remove(client);
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return _salesContext.Clients.Where(predicate).ToList();
        }

        public Client Get(int id)
        {
            return _salesContext.Clients.Find(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _salesContext.Clients;
        }

        public void Update(Client client)
        {
            _salesContext.Entry(client).State = EntityState.Modified;
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
