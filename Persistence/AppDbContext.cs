using angular_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
        {
            
        }

        public DbSet<User> users { get; set; }
        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }


        
    }
}