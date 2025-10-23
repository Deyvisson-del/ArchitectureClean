#region Usings
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;
#endregion

namespace ArchitectureClean.Domain.Entities
{

    public class Estagiario
    {

        public Guid Id { get; set; }

        public string Nome { get; private set; } = string.Empty;

        public Email Email { get; private set; } = default!;

        public Senha Senha { get; private set; } = default!;

        public Perfil Perfil { get; private set; } = Perfil.EST;

        public Status Status { get; private set; } = Status.IN;

        public Estagiario(string nome, Email email, Senha senha, Perfil perfil, Status status)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = perfil;
            Status = status;
        }

        public bool verfificarSenha(string senha) => Senha.Verificar(senha);

        public ICollection<Frequencia> Frequencias { get; set; } = new List<Frequencia>();
    }
}
