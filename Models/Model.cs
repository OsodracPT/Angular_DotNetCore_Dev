using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Models
{
    public class Model
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public Make make { get; set; }

        public int makeid { get; set; }
    }
}