using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.Domain.Entities
{
    public class Frequencia
    {
        public Guid Id { get; set; }
        public Guid EstagiarioId { get; set; }
        public DateTime DataChegada { get; private set; } = DateTime.UtcNow;
        public DateTime DataSaida { get; private set; } = DateTime.UtcNow;
        public TimeSpan HoraChegada { get; private set; } = TimeSpan.Zero;
        public TimeSpan HoraSaida { get; private set; } = TimeSpan.Zero;
        public Abono Abono { get; private set; } = Abono.NJ;


        public Frequencia(Guid estagiarioId, DateTime dataChegada, DateTime dataSaida, TimeSpan horaChegada, TimeSpan horaSaida, Abono abono)
        {
            Id = Guid.NewGuid();
            EstagiarioId = estagiarioId;
            DataChegada = dataChegada;
            DataSaida = dataSaida;
            HoraChegada = horaChegada;
            HoraSaida = horaSaida;
            Abono = abono;
        }

        public Estagiario estagiario { get; set; } = default!;
    }

}