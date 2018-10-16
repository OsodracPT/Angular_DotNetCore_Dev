using System.Linq;
using angular_dotnet.Controllers.Resources;
using angular_dotnet.Models;
using AutoMapper;

namespace angular_dotnet.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle, VehicleResource>()
            .ForMember(vr => vr.contact, opt => 
                opt.MapFrom(v => new ContactResource {
                    name = v.contact_name, 
                    email=v.contact_email, 
                    phone=v.contact_phone
                })) 
            .ForMember(vr => vr.features, opt => 
                opt.MapFrom(v => v.features.Select(vf => vf.featureid)));

            //API Resource to Domain
            CreateMap<VehicleResource, Vehicle>()
            .ForMember(v => v.contact_name, opt => opt.MapFrom(vr => vr.contact.name))
            .ForMember(v => v.contact_email, opt => opt.MapFrom(vr => vr.contact.email))
            .ForMember(v => v.contact_phone, opt => opt.MapFrom(vr => vr.contact.phone))
            .ForMember(v => v.features, 
            opt => opt.MapFrom(vr => 
            vr.features.Select(id => 
            new VehicleFeature { featureid = id})))
            ;
        }
    }
}