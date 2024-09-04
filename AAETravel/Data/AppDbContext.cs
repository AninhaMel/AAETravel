using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AAETravel.Models;
using AAETravel.Data;


namespace AAETravel.Data;
public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Experiencia> Experiencias { get; set; }
    public DbSet<Local> Locais { get; set; }
    public DbSet<ExperienciaLocal> ExperienciasLocais { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Lista> Listas { get; set; }
    public DbSet<Agencia> Agencias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Criador> Criadores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AppDbSeed appDbSeed = new(modelBuilder);

        modelBuilder.Entity<ExperienciaLocal>()
            .HasKey(el => new { el.ExperienciaId, el.LocalId });

        modelBuilder.Entity<ExperienciaLocal>()
            .HasOne(el => el.Experiencia)
            .WithMany(e => e.ExperienciasLocais)
            .HasForeignKey(el => el.ExperienciaId);

        modelBuilder.Entity<ExperienciaLocal>()
            .HasOne(el => el.Local)
            .WithMany(l => l.ExperienciasLocais)
            .HasForeignKey(el => el.LocalId);

        modelBuilder.Entity<Lista>()
            .HasOne(el => el.Usuario)
            .WithMany(e => e.Listas)
            .HasForeignKey(el => el.UsuarioId);

        modelBuilder.Entity<Lista>()
            .HasOne(el => el.Local)
            .WithMany(l => l.Listas)
            .HasForeignKey(el => el.LocalId);
    }

    
}