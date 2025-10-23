using ArchitectureClean.Domain.Interfaces;

namespace ArchitectureClean.Application.UseCases
{
    public class BuscarEstagiarioPorIdUseCase
    {
        private readonly IEstagiarioRepository _estagiarioRepository;
       
        public BuscarEstagiarioPorIdUseCase(IEstagiarioRepository estagiarioRepository)
        {
            _estagiarioRepository = estagiarioRepository;
        }
        public async Task<object> ExecuteAsync(Guid id)
        {
            var estagiario = await _estagiarioRepository.ObterPorIdAsync(id);
            if (estagiario == null) throw new Exception("Estagiário não encontrado.");
            return estagiario;
        }

    }
}
