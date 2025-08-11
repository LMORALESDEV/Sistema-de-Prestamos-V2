using Microsoft.EntityFrameworkCore;
using Sistema_de_Prestamos_V2.Models;

namespace Sistema_de_Prestamos_V2.Datos
{
    public class PrestamosDbContext : DbContext
    {
        public PrestamosDbContext(DbContextOptions<PrestamosDbContext> options) : base(options)
        {
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aquí puedes configurar las relaciones y restricciones adicionales si es necesario
        }
    }
}
