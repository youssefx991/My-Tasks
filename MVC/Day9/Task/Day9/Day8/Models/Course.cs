using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    [Table("Course")]
    public class Course
    {
        /*
         * Course should have the following properties:
        - int ID
        - string Topic
        - float Grade
         */

        [Key]
        public int ID { get; set; }

        [Required]
        public string? Topic { get; set; }

        [Required]
        [Range(0, 100)]
        public float? Grade { get; set; }
    }
}
