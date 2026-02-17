using Dotnet_API_14_API_2_API_call.Entities.Models;
using Dotnet_API_14_API_2_API_call.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_14_API_2_API_call.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IHotelService hotel) : ControllerBase
    {
        [HttpGet("GetAllHotels")]
        public async Task<ActionResult<List<Hotel>>> GetAllHotels()
        {
            var hotels =await hotel.GetAllHoetls();
            if (hotels is null)
                return BadRequest();

            return Ok(hotels);
        }
    }
}
