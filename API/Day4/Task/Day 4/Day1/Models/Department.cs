using Day1.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [UniqueDepartmentName]
        public string? Name { get; set; }

        [Required]
        public string? Location { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Manager { get; set; }

        public ICollection<Student>? Students { get; set; } = new List<Student>();

    }
}
