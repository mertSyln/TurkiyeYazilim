using Project1.Application.Dtos.OfferDtos;
using Project1.Application.Interfaces;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.UseCases
{
    public class OfferService : IOfferService
    {
        private readonly IRepository<Offer> _offerRepository;

        public OfferService(IRepository<Offer> offerRepository)
        {
            _offerRepository = offerRepository;
        }


        public async Task<bool> CreateOfferAsync(CreateOfferDto offer)
        {
            var newoffer = new Offer
            {
                SellerUserId = offer.SellerUserId,
                BuyerUserId = offer.BuyerUserId,
                BuyerItemId = offer.BuyerItemId,
                OfferPrice = offer.OfferPrice,
                OfferDescription = offer.OfferDescription,
                Quantity = offer.Quantity,
                Status = offer.Status,
            };
            await _offerRepository.AddAsync(newoffer);
            return true;
        }

        public async Task<List<Offer>> GetOfferAsync(int? UserId)
        {
            return UserId.HasValue
                ? await _offerRepository.FindAllAsync(o => o.BuyerUserId == UserId || o.SellerUserId ==UserId)
                : await _offerRepository.GetAllAsync();
        }

        public async Task<Offer> GetOfferByIdAsync(int id)
        {
            return await _offerRepository.FindAsync(o => o.OfferId == id);
        }
    }
}
