using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.ValueObject;
using System.ComponentModel;

namespace ArchitectureClean.MVC.Views.Estagiario
{
    public class EstagiarioViewModel : INotifyPropertyChanged
    {
        private Estagiario _estagiario;

        public string Nome { get; set; } = string.Empty;
        public Email? email { get; set; }
        public Senha? Senha { get; set; }
        public Perfil Perfil { get; private set; }
        public Status Status { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }   
}
