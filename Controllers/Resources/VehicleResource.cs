using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace angular_dotnet.Controllers.Resources
{
    public class VehicleResource
    {

        public int id { get; set; }

        public KeyValuePairResource model { get; set; }

        public KeyValuePairResource make { get; set; }

        public bool is_registered { get; set; }
        public ContactResource contact { get; set; }

        public DateTime last_update { get; set; }

        public ICollection<KeyValuePairResource> features{get; set;}
        public VehicleResource()
        {
            features = new Collection<KeyValuePairResource>();
        }


    }
}