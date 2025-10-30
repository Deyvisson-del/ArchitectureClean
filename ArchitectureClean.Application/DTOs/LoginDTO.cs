using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Application.DTOs
{
    public class LoginDTO
    {

        public Email email { get; set; } = default!;
        public Senha senha { get; set; } = default!;

    }
}
