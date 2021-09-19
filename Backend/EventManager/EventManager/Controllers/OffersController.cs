using EventManager.Domain.Enums;
using EventManager.Domain.Models;
using EventManager.Repo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly IOfferSevice _offerSevice;

        public OffersController(IOfferSevice offerSevice)
        {
            _offerSevice = offerSevice;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobOffer>>> GetAllOffersAsync([FromQuery] PositionType positionType)
        {
            var result = await _offerSevice.GetAllOffers(positionType);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<JobOffer>> AddAsync([FromBody] JobOffer offer)
        {
            if (await _offerSevice.AddOffer(offer))
            {
                return Ok(offer);
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<bool>> UpdateAsync([FromRoute] int id, [FromBody] JobOffer offer)
        {
            return await _offerSevice.UpdateOffer(id, offer);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<bool>> DeleteAsync([FromRoute] int id)
        {
            return await _offerSevice.DeleteOffer(id);
        }
    }
}
