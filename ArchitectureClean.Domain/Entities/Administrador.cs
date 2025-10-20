using System.ComponentModel.DataAnnotations;
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Domain.Entities;

public class Administrador
{

    public Guid Id { get; set; }

    public Email Email { get; private set; }

    public Senha Senha { get; private set; } = default!;

    public Perfil Perfil { get; private set; } = Perfil.ADM;

    public Administrador( Email email, Senha senha, Perfil perfil)
    {
        Id = Guid.NewGuid();
        Email = Email;
        Senha = Senha;
        Perfil = Perfil;
    }

    public bool verfificarSenha(string senha) => Senha.Verificar(senha);
}