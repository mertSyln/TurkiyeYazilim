using Project1.Application.Dtos.ItemDtos;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Interfaces
{
    public interface IItemService
    {
        Task<List<Item>> GetItemsAsync(int? Userid);
        Task<bool> CreateItemAsync(CreateItemDto item);
        
    }
}
