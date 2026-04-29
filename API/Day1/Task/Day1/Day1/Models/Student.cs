using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID   { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int? Age { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public string? Level { get; set; }
    }
}
