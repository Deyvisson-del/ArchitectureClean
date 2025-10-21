using ArchitectureClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureClean.Domain.Interfaces
{
    public interface IAdministradorRepository
    {
        Task<Administrador?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Administrador>> ListarAsync();
        Task AdicionarAsync(Administrador administrador);
        Task AtualizarAsync(Administrador administrador);
        Task RemoverAsync(Administrador administrador);
    }
}
