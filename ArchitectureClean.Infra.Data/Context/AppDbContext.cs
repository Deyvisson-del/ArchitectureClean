using Microsoft.EntityFrameworkCore;
using ArchitectureClean.Domain.Entities;

namespace ArchitectureClean.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Estagiario>(entity =>
            {

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Administrador>(entity =>
            {

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(60);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
            });

            modelBuilder.Entity<Frequencia>(entity =>
            {

                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Estagiario)
                      .WithMany()
                      .HasForeignKey(e => e.EstagiarioId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.Property(e => e.DataChegada).IsRequired();
                entity.Property(e => e.DataSaida).IsRequired();
                entity.Property(e => e.HoraChegada).IsRequired();
                entity.Property(e => e.HoraSaida).IsRequired();
                entity.Property(e => e.Abono).IsRequired().HasMaxLength(50);
            });

        }

    }
}