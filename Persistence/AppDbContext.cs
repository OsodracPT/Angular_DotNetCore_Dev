using angular_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> users { get; set; }
        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Feature> features { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
            new {vf.vehicleid, vf.featureid});
        }
        
    }
}