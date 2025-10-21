using Microsoft.EntityFrameworkCore;
using ArchitectureClean.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace ArchitectureClean.Infra.IoC.Persistence
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configurationAppSettigns;

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}

        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Estagiario>(entity =>
            {
                entity.ToTable("tb_Estagiarios");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.ToTable("tb_Administradores");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(60);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
                entity.Property(e => e.Perfil).IsRequired();
            });

            //modelBuilder.Entity<Frequencia>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Data).IsRequired();
            //    entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
            //    entity.HasOne(e => e.Estagiario)
            //          .WithMany()
            //          .HasForeignKey(e => e.EstagiarioId)
            //          .OnDelete(DeleteBehavior.Cascade);
            //})
        }
    }
}