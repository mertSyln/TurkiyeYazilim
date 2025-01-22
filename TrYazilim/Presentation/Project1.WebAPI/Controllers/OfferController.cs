using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Application.Dtos.OfferDtos;
using Project1.Application.Interfaces;

namespace Project1.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOffers(int? userId)
        {
            var offers = await _offerService.GetOfferAsync(userId);
            return Ok(offers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfferById(int id)
        {
            var offer = await _offerService.GetOfferByIdAsync(id);
            return offer != null ? Ok(offer) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffer(CreateOfferDto offer)
        {
            var result = await _offerService.CreateOfferAsync(offer);
            return result ? Ok(result) : NotFound();
        }
    }
}
