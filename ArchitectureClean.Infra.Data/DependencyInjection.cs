using ArchitectureClean.Application.UseCases;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Infra.Data.Context;
using ArchitectureClean.Infra.IoC.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureClean.Infra.Data
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 42))));

            services.AddScoped<IEstagiarioRepository, EstagiarioRepository>();
            services.AddScoped<CadastrarEstagiarioUseCase>();


            return services;
        }

    }
}