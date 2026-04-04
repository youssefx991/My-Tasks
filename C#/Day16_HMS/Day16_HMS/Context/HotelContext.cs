using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Day16_HMS.Context
{
    public class HotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HotelManagmentSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public virtual DbSet<Frontend> Frontends { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
