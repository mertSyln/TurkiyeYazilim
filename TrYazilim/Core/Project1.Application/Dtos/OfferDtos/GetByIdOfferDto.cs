using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Dtos.OfferDtos
{
    public class GetByIdOfferDto
    {
        public int OfferId { get; set; }
        public int SellerUserId { get; set; }
        public int BuyerUserId { get; set; }
        public int BuyerItemId { get; set; }
        public decimal OfferPrice { get; set; }
        public string OfferDescription { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}
