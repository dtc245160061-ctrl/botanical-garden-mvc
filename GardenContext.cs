using Microsoft.EntityFrameworkCore;
using GardenApp.Models;

namespace GardenApp.Data
{
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options)
            : base(options)
        {
        }

        public DbSet<Section> Sections { get; set; }
        public DbSet<Plant> Plants { get; set; }
    }
}
