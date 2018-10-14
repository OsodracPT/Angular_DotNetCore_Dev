using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Models
{
    public class Feature
    {
        public int id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string name { get; set; }
    }
}