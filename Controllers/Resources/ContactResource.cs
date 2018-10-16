using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Controllers.Resources
{
    public class ContactResource
    {
        
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        [StringLength(255)]
        public string email { get; set; }
        
        [Required]
        [StringLength(255)]
        public string phone { get; set; }

    }
}