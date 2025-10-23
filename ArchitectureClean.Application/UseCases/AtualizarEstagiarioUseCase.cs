using ArchitectureClean.Domain.Interfaces;

namespace ArchitectureClean.Application.UseCases
{
    public class AtualizarEstagiarioUseCase
    {

        private readonly IEstagiarioRepository _estagiarioRepository;
        public AtualizarEstagiarioUseCase(IEstagiarioRepository estagiarioRepository)
        {
            _estagiarioRepository = estagiarioRepository;
        }

        public async Task ExecuteAsync(object estagiario)
        {
            await _estagiarioRepository.AtualizarAsync((ArchitectureClean.Domain.Entities.Estagiario)estagiario);
        }
    }
}
