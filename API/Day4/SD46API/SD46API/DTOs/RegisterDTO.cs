using System.ComponentModel.DataAnnotations;

namespace SD46API.DTOs
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage ="Password and Confirm Password Not Matched")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }
    }
}
