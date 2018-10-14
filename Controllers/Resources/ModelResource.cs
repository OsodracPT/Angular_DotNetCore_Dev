using System.ComponentModel.DataAnnotations;
using angular_dotnet.Models;

namespace angular_dotnet.Controllers.Resources
{
    public class ModelResource
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }
    }
}