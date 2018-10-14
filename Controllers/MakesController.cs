using System.Collections.Generic;
using System.Threading.Tasks;
using angular_dotnet.Controllers.Resources;
using angular_dotnet.Models;
using angular_dotnet.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Controllers
{
    public class MakesController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public MakesController(AppDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.makes.Include(m => m.models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}