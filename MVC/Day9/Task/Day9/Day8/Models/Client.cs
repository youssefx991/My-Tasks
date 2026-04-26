using Microsoft.AspNetCore.Identity;

namespace Day9.Models
{
    public class Client : IdentityUser
    {
        //- FirstName
        //- LastName
        //- Nationality
        //- EducationLevel

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string EducationLevel { get; set; }

    }
}
