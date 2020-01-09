using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Models;

namespace SalesApp.DAL
{
    public class SalesContext : DbContext
    {
        public SalesContext(string connectionString) : base(connectionString)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
