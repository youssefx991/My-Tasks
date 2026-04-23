using Microsoft.AspNetCore.Identity;

namespace _7_NetCORE.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
    }
}
