using Microsoft.EntityFrameworkCore;
using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.ValueObject;
using ArchitectureClean.Domain.Enuns;

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
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100)
                .HasConversion(
                    email => email.Value,
                    value => new Email(value)); ;
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16).HasConversion(
                    email => email.Hash,
                    value => new Senha(value)); ;
                entity.Property(e => e.Perfil).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });



            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.OwnsOne(e => e.Email, ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.Property(e => e.Value)
                        .HasColumnName("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                });

                entity.OwnsOne(a => a.Senha, ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.Property(s => s.Hash)
                        .HasColumnName("SenhaHash")
                        .IsRequired()
                        .HasMaxLength(255);
                });


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