using System.Threading.Tasks;
using angular_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class VehicleRepository
    {
        private readonly AppDbContext context;

        public VehicleRepository(AppDbContext context)
        {
            this.context = context;

        }
        public async Task<Vehicle> GetVehicle(int id)
        {
            return await context.vehicles
            .Include(v => v.features)
            .ThenInclude(vf => vf.feature)
            .Include(v => v.model)
                .ThenInclude(m => m.make)
            .SingleOrDefaultAsync(v => v.id == id);
        }
    }
}