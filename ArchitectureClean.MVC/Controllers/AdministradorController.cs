using ArchitectureClean.Infra.IoC.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureClean.MVC.Controllers
{
    public class AdministradorController : Controller
    {

        private readonly AppDbContext _context;

        public AdministradorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var administradores = _context.Administradores.ToList();
            return View(administradores);
        }
    }
}
