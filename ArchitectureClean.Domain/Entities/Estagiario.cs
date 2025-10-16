#region Usings
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Status status { get; private set; } = Status.IN;

        public Abono abono { get; private set; } = Abono.NJ;

        public DateTime DataChegada { get; private set; } = DateTime.UtcNow;

        public DateTime DataSaida { get; private set; } = DateTime.UtcNow;


        public Estagiario(string Nome, Email email, )
        {
            
        }
    }
}
