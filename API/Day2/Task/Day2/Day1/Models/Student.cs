using Day1.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int ID   { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters long.")]
        [MaxLength(12, ErrorMessage = "Name cannot exceed 12 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name must contain only letters or spaces.")]
        public string? Name { get; set; }

        [Required]
        [Range(18, 20, ErrorMessage = "Age must be between 18 and 20.")]
        public int? Age { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public string? Level { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [UniqueEmail(ErrorMessage = "Email must be unique.")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DateInPast(ErrorMessage = "Date of Birth must be in the past.")]
        [DateMatchAge(ErrorMessage = "Date of Birth does not match the specified Age. Age must be between 18 and 20.")]
        public DateTime? DateOfBirth { get; set; }
    }
}
