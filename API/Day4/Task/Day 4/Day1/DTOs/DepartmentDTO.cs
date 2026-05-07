using Day1.Validators;
using System.ComponentModel.DataAnnotations;

namespace Day1.DTOs
{
    public class DepartmentDTO
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
    }
}
