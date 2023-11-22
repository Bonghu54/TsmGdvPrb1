using Microsoft.EntityFrameworkCore;
using TsmGdvPrb1.Models;

namespace TsmGdvPrb1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Empleado> Empleados { get; set; } = null;
        public DbSet<Producto> Productos { get; set; } = null;
        public DbSet<Rol> Roles { get; set; } = null;
        public DbSet<Usuario> Usuarios { get; set; } = null;

        public DbSet<Venta> Ventas { get; set; } = null;
    }
}
