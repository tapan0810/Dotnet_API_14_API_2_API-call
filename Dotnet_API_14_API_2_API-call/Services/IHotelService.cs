using Dotnet_API_14_API_2_API_call.Entities.Models;

namespace Dotnet_API_14_API_2_API_call.Services
{
    public interface IHotelService
    {
        public Task<List<Hotel>> GetAllHoetls();
        
    }
}
