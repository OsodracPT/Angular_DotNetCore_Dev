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
            CreateMap<Make, KeyValuePairResource>();
            CreateMap<Model, KeyValuePairResource>();
            CreateMap<Feature, KeyValuePairResource>();
            CreateMap<Vehicle, SaveVehicleResource>()
            .ForMember(vr => vr.contact, opt => 
                opt.MapFrom(v => new ContactResource {
                    name = v.contact_name, 
                    email=v.contact_email, 
                    phone=v.contact_phone
                })) 
            .ForMember(vr => vr.features, opt => 
                opt.MapFrom(v => v.features.Select(vf => vf.featureid)));

            CreateMap<Vehicle, VehicleResource> ()
                .ForMember(vr => vr.make, opt => opt.MapFrom(v => v.model.make))
                .ForMember(vr => vr.contact, opt => 
                opt.MapFrom(v => new ContactResource {
                    name = v.contact_name, 
                    email=v.contact_email, 
                    phone=v.contact_phone
                }))
                .ForMember(vr => vr.features, opt => 
                opt.MapFrom(v => v.features.Select(vf => 
                    new KeyValuePairResource{id = vf.feature.id, name=vf.feature.name}))); 

            //API Resource to Domain
            CreateMap<SaveVehicleResource, Vehicle>()
            .ForMember(v => v.id, opt => opt.Ignore())
            .ForMember(v => v.contact_name, opt => opt.MapFrom(vr => vr.contact.name))
            .ForMember(v => v.contact_email, opt => opt.MapFrom(vr => vr.contact.email))
            .ForMember(v => v.contact_phone, opt => opt.MapFrom(vr => vr.contact.phone))
            .ForMember(v => v.features, opt => opt.Ignore())
            
            .AfterMap((vr, v) => {
                //Remove unselected feature
                var removedFeatures = v.features.Where(f => !vr.features.Contains(f.featureid));
                foreach (var f in removedFeatures)
                v.features.Remove(f);

            // Add new features
                var addedFeatures = vr.features.Where(id => !v.features.Any(f => f.featureid == id)).Select(id => new VehicleFeature { featureid = id });   
                foreach (var f in addedFeatures)
                v.features.Add(f);
            });
        }
    }
}