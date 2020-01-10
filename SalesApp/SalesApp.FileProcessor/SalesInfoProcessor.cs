using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.FileProcessor.CsvParser;
using SalesApp.FileProcessor.Views;
using SalesApp.BLL.Services;
using SalesApp.BLL.DTO;
using CsvHelper;
using AutoMapper;

namespace SalesApp.FileProcessor
{
    public class SalesInfoProcessor
    {
        public void Start()
        {
            //new filewatcher
            //subcribe for events
            //eventhandler
        }

        public void Stop()
        { 

        }

        private void OnCreated(string path, string connectionString)
        {
            Task task = new Task(() => ParseInTask(path, connectionString));
            task.Start();
        }

        public void ParseInTask(string path, string connectionString)
        {
            Parser parser = new Parser();
            OrderService orderService = new OrderService(connectionString);

            IEnumerable<CsvModel> csvModels = parser.ParseToModel(path);
            IEnumerable<ClientView> clientViews = parser.ToClients(csvModels);
            IEnumerable<ItemView> itemViews = parser.ToItems(csvModels);
            IEnumerable<int> orderSums = parser.ToOrderSums(csvModels);
            string managerSecondName = parser.GetManager(path);

            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<ClientView>, ClientDTO>()).CreateMapper();
            var clientDTOs = mapper.Map<IEnumerable<ClientView>, IEnumerable<ClientDTO>>(clientViews);
            var itemDTOs = mapper.Map<IEnumerable<ItemView>, IEnumerable<ItemDTO>>(itemViews);

            var clientDTOSArray = clientDTOs.ToArray();
            var itemDTOSArray = itemDTOs.ToArray();
            var orderSumsArray = orderSums.ToArray();

            for (int i = 0; i < clientDTOSArray.Length; i++)
            {
                orderService.MakeOrder(clientDTOSArray[i], itemDTOSArray[i], new ManagerDTO() { SecondName = managerSecondName }, orderSumsArray[i]);
            }

        }
    }
}
