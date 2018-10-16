using System.ComponentModel.DataAnnotations.Schema;

namespace angular_dotnet.Models
{
    [Table("vehiclefeatures")]
    public class VehicleFeature
    {
        public int vehicleid { get; set; }

        public int featureid { get; set; }

        public Vehicle vehicle { get; set; }

        public Feature feature { get; set; }     
    }
}