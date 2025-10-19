using System.ComponentModel.DataAnnotations;
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Domain.Entities;

public class Administrador 
{

    public Guid Id { get; set; }

    public Email Email { get; private set; }

    public string Senha { get; private set; }

    public Perfil Perfil { get; private set; } Perfil.Adm; 

}