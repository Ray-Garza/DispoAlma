using DispoAlma.Entidades;
using Microsoft.EntityFrameworkCore;
namespace DispoAlma
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<DispositivoAlmacenamiento> DispositivoAlmacenamientos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
