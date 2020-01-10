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
    public class ItemService
    {
        IRepository<Item> _itemRepository;

        public ItemService(string connectionString)
        {
            _itemRepository = new ItemRepository(connectionString);
        }

        public void MakeItem(ItemDTO itemDTO)
        {
            if (itemDTO != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ItemDTO, Item>());
                IMapper mapper = config.CreateMapper();

                _itemRepository.Create(mapper.Map<ItemDTO, Item>(itemDTO));
                _itemRepository.Save();
            }
        }

        public IEnumerable<ItemDTO> GetItems()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Item, ItemDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Item>, List<ItemDTO>>(_itemRepository.GetAll());
        }

        public ItemDTO GetItem(int id)
        {
            var item = _itemRepository.Get(id);
            if (item == null)
                throw new Exception("Order not found.");

            return new ItemDTO { Id = item.Id, Name = item.Name };
        }
    }
}
