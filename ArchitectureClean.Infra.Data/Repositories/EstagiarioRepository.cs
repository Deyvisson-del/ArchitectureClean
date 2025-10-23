using ArchitectureClean.Domain.Entities;
using ArchitectureClean.Domain.Interfaces;
using ArchitectureClean.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureClean.Infra.IoC.Repositories
{
    public class EstagiarioRepository : IEstagiarioRepository
    {

        private readonly AppDbContext _context;

        public EstagiarioRepository(AppDbContext context)
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

        public async Task<IEnumerable<Estagiario>> ListarPorNomeAsync(string nome)
        {
            return await _context.Estagiarios
                .Where(e => e.Nome.Contains(nome))
                .ToListAsync();
        }

    }
}
