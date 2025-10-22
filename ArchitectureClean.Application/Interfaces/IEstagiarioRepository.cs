using ArchitectureClean.Domain.Entities;

namespace ArchitectureClean.Application.Interfaces
{
    public interface IEstagiarioRepository
    {
        Task<Estagiario?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Estagiario>> ListarAsync();
        Task AdicionarAsync(Estagiario estagiario);
        Task AtualizarAsync(Estagiario estagiario);
        Task RemoverAsync(Estagiario estagiario);
    }
}
