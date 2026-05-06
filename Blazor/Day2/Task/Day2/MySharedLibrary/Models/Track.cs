using System.ComponentModel.DataAnnotations;

namespace MySharedLibrary.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

    }
}
