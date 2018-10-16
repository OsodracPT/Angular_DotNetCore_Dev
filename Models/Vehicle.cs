using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace angular_dotnet.Models
{
    [Table("vehicles")]
    public class Vehicle
    {

        public int id { get; set; }

        public int modelid { get; set; }

        public Model model { get; set; }

        public bool is_registered { get; set; }

        [Required]
        [StringLength(255)]
        public string contact_name { get; set; }
        [StringLength(255)]
        public string contact_email { get; set; }

        
        [Required]
        [StringLength(255)]
        public string contact_phone { get; set; }

        public DateTime last_update { get; set; }

        public ICollection<VehicleFeature> features{get; set;}
        public Vehicle()
        {
            features = new Collection<VehicleFeature>();
        }



    }
}