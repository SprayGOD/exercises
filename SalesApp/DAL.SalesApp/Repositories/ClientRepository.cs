using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Models;
using SalesApp.DAL;
using System.Data.Entity;

namespace SalesApp.DAL.Repositories
{
    public class ClientRepository : BaseRepository, IRepository<Client>
    {
        public ClientRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Client client)
        {
            _salesContext.Clients.Add(client);
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
    }
}
