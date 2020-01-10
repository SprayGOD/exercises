using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Models;
using System.Data.Entity;

namespace SalesApp.DAL.Repositories
{
    public class ManagerRepository : BaseRepository, IRepository<Manager>
    {
        public ManagerRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Manager manager)
        {
            _salesContext.Managers.Add(manager);
        }

        public IEnumerable<Manager> Find(Func<Manager, bool> predicate)
        {
            return _salesContext.Managers.Where(predicate).ToList();
        }

        public Manager Get(int id)
        {
            return _salesContext.Managers.Find(id);
        }

        public IEnumerable<Manager> GetAll()
        {
            return _salesContext.Managers;
        }

        public void Update(Manager manager)
        {
            _salesContext.Entry(manager).State = EntityState.Modified;
        }
    }
}
