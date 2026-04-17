using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day5.Areas.HR.Models
{
    [Table("Employee")]
    public class Employee
    {
        /*
         * - EmpID
        - Name
        - Password
        - Salary
        - joinDate
        - Email
        - PhoneNum
        [ForeignKey("Dept")]
        - DpetID
        - Department? Dept
         */
        [Key]
        public int EmpID { get; set; }
        public string? Name { get; set; }

        public string ? Password { get; set; }
        public double? Salary { get; set; }

        public DateTime? JoinDate { get; set; }

        public string? Email { get; set; }
        public string? PhoneNum { get; set; }

        [ForeignKey("Dept")]
        public int? DeptID { get; set; }
        public virtual Department? Dept { get; set; }
    }
}
