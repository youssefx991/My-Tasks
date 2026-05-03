using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace MySharedLibrary
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "First name cannot exceed 20 characters.")]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last name cannot exceed 20 characters.")]
        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public int CountryId { get; set; }

        public virtual Country? Country { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public Gender Gender { get; set; }

        public string? Comment { get; set; }

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }

    }
}
