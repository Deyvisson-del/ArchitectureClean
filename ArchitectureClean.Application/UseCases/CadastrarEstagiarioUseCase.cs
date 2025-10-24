using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Application.DTOs;

namespace ArchitectureClean.Application.UseCases
{
    public class CadastrarEstagiarioUseCase
    {
        private readonly IEstagiarioRepository _estagiarioRepository;

        public CadastrarEstagiarioUseCase(IEstagiarioRepository estagiarioRepository)
        {
            _estagiarioRepository = estagiarioRepository;
        }

        public async Task ExecuteAsync(EstagiarioDTO estagiarioDTO)
        {
            var EstagiarioExistente = await _estagiarioRepository.ObterPorIdAsync(estagiarioDTO.Id);
            if (EstagiarioExistente != null) throw new Exception("Estagiário já cadastrado.");


            var NovoEstagiario = new Estagiario(estagiarioDTO.Nome, estagiarioDTO.Email, estagiarioDTO.Senha, Perfil.EST, Status.AT);
            await _estagiarioRepository.AdicionarAsync(NovoEstagiario);
        }

    }
}