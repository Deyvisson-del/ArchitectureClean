using Microsoft.EntityFrameworkCore;
using ArchitectureClean.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace ArchitectureClean.Infra.IoC.Persistence
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        //public DbSet<Frequencia> Frequencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //string senhaPura = "Adm@123";
            //string senhaHash = CalcularHash(senhaPura);





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
            //    entity.ToTable("tb_Frequencias");
            //    entity.HasKey(e => e.Id);
            //    entity.HasOne(e => e.Estagiario)
            //          .WithMany()
            //          .HasForeignKey(e => e.EstagiarioId)
            //          .OnDelete(DeleteBehavior.Cascade);
            //    entity.Property(e => e.DataChegada).IsRequired();
            //    entity.Property(e => e.DataSaida).IsRequired();
            //    entity.Property(e => e.HoraChegada).IsRequired();
            //    entity.Property(e => e.HoraSaida).IsRequired();
            //    entity.Property(e => e.Abono).IsRequired().HasMaxLength(50);
            //});

            //modelBuilder.Entity<Administrador>().HasData(
            //    new Administrador
            //   {
            //       Id = 1,
            //       Nome = "Administrador",
            //       Email = "adm@secti.com",
            //       Senha = senhaHash,
            //       Perfil = Domain.Enuns.Perfil.ADM
            //   });
        }

        private static string CalcularHash(string input)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToHexString(bytes);
            }
        }
    }
}