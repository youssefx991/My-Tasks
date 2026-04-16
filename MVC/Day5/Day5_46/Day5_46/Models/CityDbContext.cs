using Microsoft.EntityFrameworkCore;

namespace Day5_46.Models
{
    public class CityDbContext: DbContext
    {
        public CityDbContext():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CityDB_46;Integrated Security=True;Trust Server Certificate=True"); 
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }
}
