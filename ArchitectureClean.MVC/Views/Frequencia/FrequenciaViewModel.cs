using ArchitectureClean.Domain.Enuns;
using ArchitectureClean.Domain.ValueObject;

namespace ArchitectureClean.MVC.Views.Frequencia

{
    public class FrequenciaViewModel
    {
        public Guid Id { get; private set; }
        public Guid EstagiarioId { get; private set; }
        public DateTime DataChegada { get; private set; } = DateTime.UtcNow;
        public DateTime DataSaida { get; private set; } = DateTime.UtcNow;
        public TimeSpan HoraChegada { get; private set; } = TimeSpan.Zero;
        public TimeSpan HoraSaida { get; private set; } = TimeSpan.Zero;
        public Abono Abono { get; private set; } = Abono.NJ;
    }
}
