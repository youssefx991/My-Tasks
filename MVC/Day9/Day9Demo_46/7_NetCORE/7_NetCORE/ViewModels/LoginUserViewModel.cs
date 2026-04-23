using System.ComponentModel.DataAnnotations;

namespace _7_NetCORE.ViewModels
{
    public class LoginUserViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your username.")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
