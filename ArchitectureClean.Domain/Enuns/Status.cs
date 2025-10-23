using System.ComponentModel;
namespace ArchitectureClean.Domain.Enuns
{
    public enum Status
    {
        [Description("Ativo")] AT,
        [Description("Inativo")] IN,
        [Description("Suspenso")] SP,

    }
}