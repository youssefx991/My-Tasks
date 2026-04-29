using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=APIDay1;Persist Security Info=True;User ID=sa;Password=iti;Encrypt=True;Trust Server Certificate=True");
        }

        public  DbSet<Student> Students { get; set; }
    }
}
