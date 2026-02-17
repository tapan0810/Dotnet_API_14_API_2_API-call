using Dotnet_API_14_API_2_API_call.Data;
using Dotnet_API_14_API_2_API_call.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_14_API_2_API_call.Services
{
    public class HotelService(HotelDbContext _context) : IHotelService
    {
        public async Task<List<Hotel>> GetAllHoetls()
        {
            var hotels =await _context.Hotels.
                 Select(s => new Hotel
                 {
                     HotelId = s.HotelId,
                     HotelName = s.HotelName,
                     Address = s.Address,
                     City = s.City,
                     Phone = s.Phone
                 }).ToListAsync();

            return hotels;
        }
    }
}
