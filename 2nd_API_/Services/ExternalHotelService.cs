using _2nd_API_.Entities;
using _2nd_API_.Services.Interface;
using System.Net.Http;

namespace _2nd_API_.Services
{
    public class ExternalHotelService(HttpClient httpClient,IConfiguration configuration) : IExternalHotelService
    {
        public async  Task<List<HotelDto>> GetAllHotelFromApi()
        {
            var baseUrl = configuration["ExternalApi:BaseUrl"];

            var response = await httpClient.GetAsync($"{baseUrl}/api/Hotel/GetAllHotels");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to fetch hotels from external API");
            }

            var hotels = await response.Content.ReadFromJsonAsync<List<HotelDto>>();

            return hotels ?? new List<HotelDto>();
        }
    }
}
