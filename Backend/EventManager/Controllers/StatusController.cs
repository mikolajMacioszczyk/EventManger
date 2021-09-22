using EventManager.Repo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EventManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpPut()]
        [Route("register/{employeeId}/{offerId}")]
        public async Task<ActionResult<bool>> RegisterToOfferAsync([FromRoute] int employeeId, int offerId)
        {
            if (await _statusService.RegisterToOffer(employeeId, offerId))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
