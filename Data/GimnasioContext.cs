using Microsoft.EntityFrameworkCore;
using GimnasioGrupo2.Models;

namespace GimnasioGrupo2.Data
{
 public class GimnasioContext : DbContext
 {
 public GimnasioContext(DbContextOptions<GimnasioContext> options)
 : base(options)
 {
 }

 public DbSet<Gimnasio> Gimnasios { get; set; }
 public DbSet<Maquina> Maquinas { get; set; }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
 base.OnModelCreating(modelBuilder);

 // Configuraciones expl�citas b�sicas para evitar ambig�edades
 modelBuilder.Entity<Gimnasio>().HasKey(g => g.id);
 modelBuilder.Entity<Maquina>().HasKey(m => m.Id);

 // Si en el futuro se cambian nombres de propiedades o se agregan relaciones,
 // a�adirlas aqu� con Fluent API.
 }
 }
}
