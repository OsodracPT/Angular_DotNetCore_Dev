using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using angular_dotnet.Models;

namespace angular_dotnet.Controllers.Resources
{
    public class SaveVehicleResource
    {
                
        public int id { get; set; }

        public int modelid { get; set; }

        public Model model { get; set; }

        public bool is_registered { get; set; }

        public ContactResource contact { get; set; }
        public ICollection<int> features{get; set;}

        public SaveVehicleResource()
        {
            features = new Collection<int>();
        }


    }
}