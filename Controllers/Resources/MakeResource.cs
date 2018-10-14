using System.Collections.Generic;
using System.Collections.ObjectModel;
using angular_dotnet.Models;

namespace angular_dotnet.Controllers.Resources
{
    public class MakeResource
    {
        public int id { get; set; }
        
        public string name { get; set; }
        public ICollection<ModelResource> models{get; set;}

        public MakeResource()
        {
            models = new Collection<ModelResource>();
        }
    }
}