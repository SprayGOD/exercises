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
    public class ManagerService
    {
        private ManagerRepository _managerRepository;

        public ManagerService(string connectionString)
        {
            _managerRepository = new ManagerRepository(connectionString);
        }

        public void MakeManager(ManagerDTO managerDTO)
        {
            if (managerDTO != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ManagerDTO, Manager>());
                IMapper mapper = config.CreateMapper();

                _managerRepository.Create(mapper.Map<ManagerDTO, Manager>(managerDTO));
                _managerRepository.Save();
            }
        }

        public IEnumerable<ManagerDTO> GetManagers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Manager>, List<ManagerDTO>>(_managerRepository.GetAll());
        }

        public ManagerDTO GetManager(int id)
        {
            var manager = _managerRepository.Get(id);
            if (manager == null)
                throw new Exception("Manager not found.");

            return new ManagerDTO { Id = manager.Id, SecondName = manager.SecondName };
        }

        public IEnumerable<ManagerDTO> Find(Func<Manager, bool> predicate)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Manager>, List<ManagerDTO>>(_managerRepository.Find(predicate));
        }
    }
}
