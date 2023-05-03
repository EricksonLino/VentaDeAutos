using Microsoft.EntityFrameworkCore;
using VentaDeAutos.Entity;

namespace VentaDeAutos.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet <AutoCedan> AutoCedans { get; set; }
    }
}
