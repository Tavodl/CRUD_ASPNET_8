using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
    }
}
