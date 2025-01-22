using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Application.Dtos.ItemDtos;
using Project1.Application.Interfaces;

namespace Project1.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems(int? userId)
        {
            var items = await _itemService.GetItemsAsync(userId);
            return Ok(items);
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(CreateItemDto item)
        {
            var result = await _itemService.CreateItemAsync(item);
            return result ? Ok(result) : BadRequest();
        }
    }
}
