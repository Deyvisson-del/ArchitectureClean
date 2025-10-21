using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Application.DTOs
{
    public class AdministradorDTO
    {
        public Guid Id { get; set; }

        public string Nome { get; private set; } = string.Empty;

        public Email Email { get; private set; } = default!;

        public Senha Senha { get; private set; } = default!;

        public Perfil Perfil { get; private set; } = Perfil.ADM;
    }
}
