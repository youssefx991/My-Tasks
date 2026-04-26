using System.ComponentModel.DataAnnotations;

namespace Day9.ViewModels
{
    public class LoginUserViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
