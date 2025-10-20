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

        public Senha Senha { get; private set; }

        public Perfil Perfil { get; private set; } = Perfil.EST;

        public Status Status { get; private set; } = Status.IN;

        public Abono Abono { get; private set; } = Abono.NJ;

        public DateTime DataChegada { get; private set; } = DateTime.UtcNow;

        public DateTime DataSaida { get; private set; } = DateTime.UtcNow;


        public Estagiario(string nome ,Email email, Senha senha, Perfil perfil, Status status, Abono abono)
        {

            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = Perfil;
            Status = status;
            Abono = abono;

        }

        public bool verfificarSenha(string senha) => Senha.Verificar(senha);
    }
}
