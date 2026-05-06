using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SD46API.Models
{
    public class Employee
    {
     //   [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [ForeignKey(nameof(Department))]
      //  [JsonIgnore]
        public int DeptId { get; set; }
       // [JsonIgnore]
        public Department? Department { get; set; }
    }
}
