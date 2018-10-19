using System.Threading.Tasks;
using angular_dotnet.Models;

namespace angular_dotnet.Persistence
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);

         void Add(Vehicle vehicle);

         void Remove(Vehicle vehicle);
    }
}