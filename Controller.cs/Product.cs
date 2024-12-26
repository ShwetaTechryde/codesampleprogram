using Microsoft.EntityFrameworkCore;
using codesampleprogram.Models;

namespace codesampleprogram.Controller
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-APMVBAH;initial catalog=Airlinesfeddback;integrated security=true;TrustServerCertificate=True");
        }
    }
}
