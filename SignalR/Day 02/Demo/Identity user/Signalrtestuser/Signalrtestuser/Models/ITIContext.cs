using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Signalrtestuser.Models
{
    public class ITIContext:IdentityDbContext
    {
        public ITIContext(DbContextOptions<ITIContext>option):base(option)
        {
            
        }
    }
}
