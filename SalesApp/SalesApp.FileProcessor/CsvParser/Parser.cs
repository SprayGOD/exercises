using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.FileProcessor.Views;
using CsvHelper;


namespace SalesApp.FileProcessor.CsvParser
{
    public class Parser
    {
        public IEnumerable<CsvModel> ParseToModel(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader))
            {
                var records = csvReader.GetRecords<CsvModel>();
                return records;
            }
        }

        public string GetManager(string path)
        {
            string fileName = Path.GetFileName(path);
            string[] managerSecondName = fileName.Split('_');
            return managerSecondName[0];
        }

        public IEnumerable<ClientView> ToClients(IEnumerable<CsvModel> csvModels)
        {
            IList<ClientView> clientViews = new List<ClientView>();

            foreach (var item in csvModels)
            {
                clientViews.Add(new ClientView() { Name = item.ClientName });
            }
            return clientViews;
        }

        public IEnumerable<ItemView> ToItems(IEnumerable<CsvModel> csvModels)
        {
            IList<ItemView> itemViews = new List<ItemView>();

            foreach (var item in csvModels)
            {
                itemViews.Add(new ItemView() { Name = item.ClientName });
            }
            return itemViews;
        }

        public IEnumerable<int> ToOrderSums(IEnumerable<CsvModel> csvModels)
        {
            IList<int> sums = new List<int>();

            foreach (var item in csvModels)
            {
                sums.Add(item.Sum);
            }
            return sums;
        }
    }
}
