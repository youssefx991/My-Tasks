using System.ComponentModel.DataAnnotations;

namespace _7_NetCORE.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string Job { get; set; }
    }
}
