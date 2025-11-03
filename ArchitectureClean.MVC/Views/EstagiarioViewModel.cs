using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.MVC.Views
{
    public class EstagiarioViewModel
    {
        public string Nome { get; set; } = string.Empty;
        public Email email { get; set; }
        public Senha Senha { get; set; }
        public Perfil Perfil { get; private set; }
        public Status Status { get; private set; }
    }
}
