using System.ComponentModel.DataAnnotations;

namespace Day1.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password does not match the Password.")]
        public string ConfirmPassword { get; set; }
    }
}
