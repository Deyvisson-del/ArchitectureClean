using ArchitectureClean.Domain.Interfaces;

namespace ArchitectureClean.Application.UseCases
{
    public class DeletarEstagiarioUseCase
    {

        private readonly IEstagiarioRepository _estagiarioRepository;
        public DeletarEstagiarioUseCase(IEstagiarioRepository estagiarioRepository)
        {
            _estagiarioRepository = estagiarioRepository;
        }
        public async Task ExecuteAsync(Guid id)
        {
            var estagiario = await _estagiarioRepository.ObterPorIdAsync(id);
            if (estagiario == null) throw new Exception("Estagiário não encontrado.");
            await _estagiarioRepository.RemoverAsync(estagiario);
        }
    }
}
