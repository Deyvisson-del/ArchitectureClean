#region Documentation
/// <sumary>
/// Entity Frequencia
/// </sumary>
/// <param name="Id"> ID Frequencia</param>
/// <param name="EstagiarioId"> ID Estagiario</param>
/// <param name="DataChegada"> Data de Chegada</param>
/// <param name="DataSaida"> Data de Saída</param>
/// <param name="HoraChegada"> Hora de Chegada</param>
/// <param name="HoraSaida"> Hora de Saída</param>
/// <param name="Abono"> Abono</param>
#endregion 

namespace ArchitectureClean.Domain.Entities
{
    public class Frequencia
    {
        public Guid Id { get; private set; }
        public Guid EstagiarioId { get; private set; }
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

        public virtual Estagiario Estagiario { get; set; } = default!;
    }

}