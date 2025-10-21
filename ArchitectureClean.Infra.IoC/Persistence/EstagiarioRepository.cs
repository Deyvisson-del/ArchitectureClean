using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureClean.Infra.IoC.Persistence
{
    public class EstagiarioRepository : IEstagiarioRepository
    {

        private readonly AppContext _context;

        public EstagiarioRepository(AppContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Estagiario>> ListarAsync() => await _context.Estagiarios.ToListAsync();

        public async Task<Estagiario?> ObterPorIdAsync(Guid id) => await _context.Estagiarios.FindAsync(id);
        public Task AdicionarAsync(Estagiario estagiario)
        {
            _context.Estagiarios.Add(estagiario);
            return _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Estagiario estagiario)
        {
           _context.Estagiarios.Update(estagiario);
            await _context.SaveChangesAsync();
        }
       
        public async Task RemoverAsync(Estagiario estagiario)
        {
            _context.Estagiarios.Remove(estagiario);
            await _context.SaveChangesAsync();
        }
    }
}
