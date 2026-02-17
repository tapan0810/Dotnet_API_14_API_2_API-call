using _2nd_API_.Entities;

namespace _2nd_API_.Services.Interface
{
    public interface IExternalHotelService
    {
        public Task<List<HotelDto>> GetAllHotelFromApi();
    }
}
