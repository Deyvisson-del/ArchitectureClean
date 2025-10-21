using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureClean.Application.UseCases
{
    public class CadastrarEstagiarioUseCase
    {
        private readonly IEstagiarioRepository _estagiarioRepository;

        public CadastrarEstagiarioUseCase(IEstagiarioRepository estagiarioRepository)
        {
            _estagiarioRepository = estagiarioRepository;
        }

        public async Task Execute(string nome, string email, string senha)
        {
            var estagiario = new Estagiario(nome, new Email(email), new Senha(senha), Perfil.EST, Status.AT);
            await _estagiarioRepository.AdicionarAsync(estagiario);
        }
    }
}
