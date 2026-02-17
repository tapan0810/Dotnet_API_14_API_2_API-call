using Dotnet_API_14_API_2_API_call.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_14_API_2_API_call.Data
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
