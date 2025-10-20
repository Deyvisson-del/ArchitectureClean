using ArchitectureClean.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ArchitectureClean.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; };
        public DbSet<Frequencia> Frequencias ;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estagiario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
                entity.HasKey(e => e.Status).IsRequired();

            });

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(60);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
                entity.HasKey(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Adminstrador>(entity =>
            {
                Id = 1,
                Nome = "João Silva",
                Email = "administrador@adm.com",
                Senha = "Adm123@",
                Perfil = Perfil.ADM,
            }); 


            modelBuilder.Entity<Frequencia>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Data).IsRequired();
                entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
                entity.HasOne(e => e.Estagiario)
                      .WithMany()
                      .HasForeignKey(e => e.EstagiarioId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}