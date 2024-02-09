using ApiProducerN5.Models;
using ApiProducerN5.Models.Empleados;
using Microsoft.EntityFrameworkCore;

namespace ApiProducerN5.Data
{

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<TipoPermisos> TiposPermisos { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>()
                 .HasOne(e => e.TipoPermiso)
                 .WithMany(p => p.Empleados)
                 .HasForeignKey(e => e.IdTipoPermiso);

            modelBuilder.Entity<Permisos>()
                .HasOne(p => p.TipoPermiso)
                .WithMany(tp => tp.Permisos)
                .HasForeignKey(p => p.IdTipoPermiso);
        }
    }
}
