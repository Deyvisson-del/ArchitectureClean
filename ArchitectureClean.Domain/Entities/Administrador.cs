using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Domain.Entities;

public class Administrador
{

    public Guid Id { get; private set; }

    public string Nome { get; private set; } = string.Empty;

    public Email Email { get; private set; } = default!;

    public Senha Senha { get; private set; } = default!;

    public Perfil Perfil { get; private set; } = Perfil.ADM;

    public Administrador(Guid ID, string nome, string email, string senha, Perfil perfil)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        Senha = senha;
        Perfil = perfil;
    }

    public Administrador()
    {

    }

    public bool VerificarSenha(string senha) => Senha.Verificar(senha);
}