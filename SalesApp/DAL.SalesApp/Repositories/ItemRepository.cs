using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Models;
using System.Data.Entity;

namespace SalesApp.DAL.Repositories
{
    public class ItemRepository : BaseRepository, IRepository<Item>
    {
        public ItemRepository(string connectionString)
        {
            _salesContext = new SalesContext(connectionString);
        }

        public void Create(Item item)
        {
            _salesContext.Items.Add(item);
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
    }
}
