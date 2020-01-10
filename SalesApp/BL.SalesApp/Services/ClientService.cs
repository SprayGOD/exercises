using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.DAL.Repositories;
using SalesApp.DAL.Models;
using SalesApp.BLL.DTO;
using AutoMapper;

namespace SalesApp.BLL.Services
{
    public class ClientService
    {
        private ClientRepository _clientRepository;

        public ClientService(string connectionString)
        {
            _clientRepository = new ClientRepository(connectionString);
        }

        public void MakeClient(ClientDTO clientDTO)
        {
            if (clientDTO != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientDTO, Client>());
                IMapper mapper = config.CreateMapper();

                _clientRepository.Create(mapper.Map<ClientDTO, Client>(clientDTO));
                _clientRepository.Save();
            }
        }

        public IEnumerable<ClientDTO> GetClients()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Client>, List<ClientDTO>>(_clientRepository.GetAll());
        }

        public ClientDTO GetClient(int id)
        {
            var client = _clientRepository.Get(id);
            if (client == null)
                throw new Exception("Order not found.");

            return new ClientDTO { Id = client.Id, Name = client.Name };
        }

        public IEnumerable<ClientDTO> Find(Func<Client, bool> predicate)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Client>, List<ClientDTO>>(_clientRepository.Find(predicate));
        }
    }
}
