using Project1.Application.Dtos.ItemDtos;
using Project1.Application.Interfaces;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.UseCases
{
    public class ItemService : IItemService
    {
        private readonly IRepository<Item> _itemRepository;

        public ItemService(IRepository<Item> itemRepository)
        {
            this._itemRepository = itemRepository;
        }

        public async Task<bool> CreateItemAsync(CreateItemDto item)
        {
            var newitem = new Item
            {
                UserId = item.UserId,
                ItemName = item.ItemName,
                ItemDescription = item.ItemDescription,
                ItemImage = item.ItemImage,
                ItemProperties = item.ItemProperties,
                Quantity = item.Quantity,
            };
            await _itemRepository.AddAsync(newitem);
            return true;
        }

        public async Task<List<Item>> GetItemsAsync(int? Userid)
        {
            return Userid.HasValue
                ? await _itemRepository.FindAllAsync(i => i.UserId == Userid)
                : await _itemRepository.GetAllAsync();
        }
    }
}
