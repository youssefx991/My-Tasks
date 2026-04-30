using Day1.Validators;
using System.ComponentModel.DataAnnotations;

namespace Day1.DTOs
{
    public class DepartmentWithStudentsDTO
    {
        [Required]
        [UniqueDepartmentName]
        public string? DepartmentName { get; set; }
        public List<string>? StudentsNames { get; set; }
        public int? StudentsCount { get; set; }
        public string? Msg { get; set; }
    }
}
