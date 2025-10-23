using ArchitectureClean.Application.UseCases;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Infra.IoC.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectureClean.Infra.IoC
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddScoped<IEstagiarioRepository, EstagiarioRepository>();
            services.AddScoped<CadastrarEstagiarioUseCase>();
            return services;
        }

    }
}
