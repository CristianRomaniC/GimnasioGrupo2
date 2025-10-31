using Microsoft.EntityFrameworkCore;
using GimnasioGrupo2.Models;

namespace GimnasioGrupo2.Data
{
 public class GimnasioContext : DbContext
 {
 public GimnasioContext(DbContextOptions<GimnasioContext> options) : base(options) { }

 public DbSet<Gimnasio> Gimnasios { get; set; }
 public DbSet<Cliente> Clientes { get; set; }
 public DbSet<Rutina> Rutinas { get; set; }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
 base.OnModelCreating(modelBuilder);

 // Claves explícitas según los modelos actuales
 modelBuilder.Entity<Gimnasio>().HasKey(g => g.id);
 
 modelBuilder.Entity<Rutina>().HasKey(r => r.Id);
 modelBuilder.Entity<Cliente>().HasKey(c => c.id);

 // Relaciones: Gimnasio1:N Clientes y1:N Rutinas (propiedades sombra para FK)
 modelBuilder.Entity<Gimnasio>()
 .HasMany(g => g.Clientes)
 .WithOne()
 .HasForeignKey("GimnasioId")
 .IsRequired(false);

 modelBuilder.Entity<Gimnasio>()
 .HasMany(g => g.Rutinas)
 .WithOne()
 .HasForeignKey("GimnasioId")
 .IsRequired(false);

 // Relación1:1 Cliente - Rutina
 modelBuilder.Entity<Cliente>()
 .HasOne(c => c.Rutina)
 .WithOne()
 .HasForeignKey<Cliente>(c => c.RutinaId)
 .IsRequired(false);
 }
 }
}
