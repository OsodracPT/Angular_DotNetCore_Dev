using System.Collections;
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
    public class FeaturesController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
            {
            var features = await context.features.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
            }
        }
    }