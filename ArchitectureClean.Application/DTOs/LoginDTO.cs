using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Application.DTOs
{
    public class LoginDTO
    {

        public Email Email { get; set; } 
        public Senha Senha { get; set; }

        public LoginDTO(Email email, Senha senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
