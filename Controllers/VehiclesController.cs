using System;
using System.Threading.Tasks;
using angular_dotnet.Controllers.Resources;
using angular_dotnet.Models;
using angular_dotnet.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace angular_dotnet.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly AppDbContext context;
        public VehiclesController(IMapper mapper, AppDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.last_update = DateTime.Now;
            context.vehicles.Add(vehicle);
            await context.SaveChangesAsync();

            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
    }
}