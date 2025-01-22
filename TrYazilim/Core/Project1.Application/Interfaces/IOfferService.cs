using Project1.Application.Dtos.OfferDtos;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Interfaces
{
    public interface IOfferService
    {
        Task<List<Offer>> GetOfferAsync(int? UserId);
        Task<Offer> GetOfferByIdAsync(int id);
        Task<bool> CreateOfferAsync(CreateOfferDto offer);
    }
}
