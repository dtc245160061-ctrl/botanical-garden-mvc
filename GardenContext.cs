using Microsoft.EntityFrameworkCore;

namespace GardenApp
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
