using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Dtos.ItemDtos
{
    public class GetByIdItemDto
    {
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemImage { get; set; }
        public List<string> ItemProperties { get; set; }
        public int Quantity { get; set; }
    }
}
