using System.Collections.Generic;
using System.Collections.ObjectModel;
using angular_dotnet.Models;

namespace angular_dotnet.Controllers.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        public ICollection<KeyValuePairResource> models{get; set;}

        public MakeResource()
        {
            models = new Collection<KeyValuePairResource>();
        }
    }
}