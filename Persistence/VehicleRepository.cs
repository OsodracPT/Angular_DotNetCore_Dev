using System.Threading.Tasks;
using angular_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext context;

        public VehicleRepository(AppDbContext context)
        {
            this.context = context;

        }
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated =true)
        {
            if (!includeRelated)
                return await context.vehicles.FindAsync(id);

            return await context.vehicles
            .Include(v => v.features)
            .ThenInclude(vf => vf.feature)
            .Include(v => v.model)
                .ThenInclude(m => m.make)
            .SingleOrDefaultAsync(v => v.id == id);
        }

        public void Add(Vehicle vehicle){
            context.vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle){
            context.vehicles.Remove(vehicle);
        }
    }
}