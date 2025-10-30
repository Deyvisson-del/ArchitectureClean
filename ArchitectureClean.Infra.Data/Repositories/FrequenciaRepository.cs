using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureClean.Infra.Data.Repositories
{
    public class FrequenciaRepository : IFrequenciaRepository
    {
        private readonly AppDbContext _context;
     
        public FrequenciaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Frequencia frequencia)
        {
            _context.Frequencias.Add(frequencia);
            return _context.SaveChangesAsync();
        }

        public Task AtualizarAsync(Frequencia frequencia)
        {
            _context.Frequencias.Update(frequencia);
            return _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Frequencia>> ListarAsync()
        {
            _context.Frequencias.ToListAsync();
            return Task.FromResult<IEnumerable<Frequencia>>(_context.Frequencias);
        }

        public Task<Frequencia?> ObterPorIdAsync(Guid id)
        {
            _context.Frequencias.FindAsync(id); 
            return Task.FromResult<Frequencia?>(_context.Frequencias.Find(id));
        }

        public Task RemoverAsync(Frequencia frequencia)
        {
           _context.Frequencias.Remove(frequencia);
              return _context.SaveChangesAsync();
        }
    }
}
