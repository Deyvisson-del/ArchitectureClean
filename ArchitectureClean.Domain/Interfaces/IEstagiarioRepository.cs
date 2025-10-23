using ArchitectureClean.Domain.Entities;

namespace ArchitectureClean.Domain.Interfaces
{
    public interface IEstagiarioRepository
    {
        Task<Estagiario?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Estagiario>> ListarAsync();
        Task<IEnumerable<Estagiario>> ListarPorNomeAsync(string nome);
        Task AdicionarAsync(Estagiario estagiario);
        Task AtualizarAsync(Estagiario estagiario);
        Task RemoverAsync(Estagiario estagiario);
    }
}
