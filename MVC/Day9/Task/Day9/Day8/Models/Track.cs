using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    [Table("Track")]
    public class Track
    {
        /*
         Track should have the following properties:
        - int ID
        - string Name
        - string Description
        - IEnumerable<Trainee>? Trainees --> Nullable
         */

        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        public IEnumerable<Trainee>? Trainees { get; set; }
    }
}
