using ArchitectureClean.Domain.Entities;

namespace ArchitectureClean.Application.Interfaces
{
    public interface IAdministradorRepository
    {
        Task<Administrador?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Administrador>> ListarAsync();
        Task AdicionarAsync(Administrador administrador);
        Task AtualizarAsync(Administrador administrador);
        Task RemoverAsync(Administrador administrador);
    }
}
