
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Application.DTOs
{
    public class EstagiarioDTO
    {
        public Guid Id { get; set; }

        public string Nome { get; private set; }

        public Email Email { get; private set; }

        public Senha Senha { get; private set; }

        public Perfil Perfil { get; private set; }

        public Status Status { get; private set; }

        public EstagiarioDTO(Guid id, string nome, Email email, Senha senha, Perfil perfil, Status status)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = perfil;
            Status = status;
        }
    }
}