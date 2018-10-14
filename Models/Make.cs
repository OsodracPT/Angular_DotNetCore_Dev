using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Models
{
    public class Make
    {
        public int id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public ICollection<Model> models{get; set;}

        public Make()
        {
            models = new Collection<Model>();
        }
    }
}