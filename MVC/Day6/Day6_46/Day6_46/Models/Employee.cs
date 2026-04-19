using System.ComponentModel.DataAnnotations;

namespace Day6_46.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinAge(21)]
        public int Age { get; set; }
    }
}
