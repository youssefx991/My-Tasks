using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Day3.Data
{
    public class Day3Context(DbContextOptions<Day3Context> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
