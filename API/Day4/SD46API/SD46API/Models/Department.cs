using Microsoft.AspNetCore.Mvc;
using SD46API.Validators;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SD46API.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        [MaxLength(15, ErrorMessage = "Name cannot exceed 15 characters.")]
        [Required(ErrorMessage ="Name Required")]
        //[Unique]
        public string Name { get; set; }
        [RegularExpression("[a-zA-Z]{5,20}", ErrorMessage = "Manager name must be between 5 and 20 alphabetic characters.")]
        public string Manager { get; set; }
       // [RegularExpression("(UK|USA)")]
        public string? Location { get; set; }
        [DateInPast(ErrorMessage ="Date must be in Past")]
        //  [Remote("checkName","Department")]
       
        public DateTime? OpenDate { get; set; }
        //[JsonIgnore]

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
