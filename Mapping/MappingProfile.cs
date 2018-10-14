using angular_dotnet.Controllers.Resources;
using angular_dotnet.Models;
using AutoMapper;

namespace angular_dotnet.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}