using ArchitectureClean.Application.Interfaces;
using ArchitectureClean.Infra.IoC.Persistence;
using ArchitectureClean.Infra.IoC.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureClean.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraIoC(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql("server=127.0.0.1;port=3366;uid=rootpwd=root;database=DB_CleanArch;", ServerVersion.AutoDetect("server=127.0.0.1;port=3366;uid=rootpwd=root;database=DB_CleanArch;")));

            services.AddScoped<IEstagiarioRepository, EstagiarioRepository>();
            return services;
        }
    }
}
