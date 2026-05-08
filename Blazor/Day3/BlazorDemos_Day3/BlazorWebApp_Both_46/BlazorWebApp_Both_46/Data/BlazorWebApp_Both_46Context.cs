using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BlazorWebApp_Both_46.Data
{
    public class BlazorWebApp_Both_46Context(DbContextOptions<BlazorWebApp_Both_46Context> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
