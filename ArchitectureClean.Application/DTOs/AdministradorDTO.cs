using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Application.DTOs
{
    public class AdministradorDTO
    {
        public Guid Id { get; set; }

        public string Nome { get; private set; } 

        public Email Email { get; private set; }

        public Senha Senha { get; private set; } 

        public Perfil Perfil { get; private set; }

        public AdministradorDTO(Guid ID, string nome, string email, string senha, Perfil perfil)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = perfil;
        }
    }
}
