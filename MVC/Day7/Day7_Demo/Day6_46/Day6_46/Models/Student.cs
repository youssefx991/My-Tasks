using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6_46.Models
{
    [Table("StudentInfo")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "U have to enter a Name!!!")]
        [MaxLength(30, ErrorMessage = "Too long Name, Name cannot exceed 30 characters!!!")]
        [Display(Name = "StudentName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "U have to enter a Password!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
            
        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Mark must be between 0 and 10!!!")]
        public int Mark { get; set; }

        [Required(ErrorMessage = "U have to enter an Email!!!")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Not a valid EmailAddress")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@fpt\.edu\.vn$", ErrorMessage = "Email must be in the form at of Email"])
        
        [UniqueEmail]
        public string Email { get; set; }

        [Required(ErrorMessage = "U have to re-type ur email...")]
        [Compare("Email", ErrorMessage = "Email and Confirm Email do not match!!!")]
        public string ConfirmEmail { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        public virtual Department? Department { get; set; }

    }

    public enum Gender { Male , Female }
}
