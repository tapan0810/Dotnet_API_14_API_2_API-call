using _2nd_API_.Entities;
using _2nd_API_.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2nd_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController(IExternalHotelService externalHotelService) : ControllerBase
    {
        [HttpGet("GetAllHotelReports")]
        public async Task<ActionResult<List<HotelDto>>> GetAllHotelDetails()
        {
            var hotels = await externalHotelService.GetAllHotelFromApi();

            var response = new
            {
                TotalHotel = hotels.Count,
                Hotels = hotels
            };

            return Ok(response);
        }
    
    }
}
