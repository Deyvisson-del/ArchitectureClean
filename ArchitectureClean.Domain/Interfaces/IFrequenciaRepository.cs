using ArchitectureClean.Domain.Entities;

namespace ArchitectureClean.Domain.Interfaces
{
    public interface IFrequenciaRepository
    {
        Task<Frequencia?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Frequencia>> ListarAsync();
        Task AdicionarAsync(Frequencia frequencia);
        Task AtualizarAsync(Frequencia frequencia);
        Task RemoverAsync(Frequencia frequencia);


    }
}
