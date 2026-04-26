using Day9.Models;
using System.ComponentModel.DataAnnotations;

namespace Day9.ViewModels
{
    public class RegisterUserViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string EducationLevel { get; set; }


    }
}
