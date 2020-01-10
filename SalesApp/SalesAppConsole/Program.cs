using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.BLL.DTO;
using SalesApp.BLL.Services;
using SalesApp.FileProcessor;

namespace SalesAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SalesAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SalesInfoProcessor salesInfoProcessor = new SalesInfoProcessor();
            
            salesInfoProcessor.ParseInTask(@"D:\CsvFiles\Alexeev_20122019.csv", connectionString);
            salesInfoProcessor.ParseInTask(@"D:\CsvFiles\Nazyrbaev_10102018.csv", connectionString);
            //orderService.MakeOrder(orderDTO1);
            //orderService.MakeOrder(orderDTO2);

        }
    }
}
