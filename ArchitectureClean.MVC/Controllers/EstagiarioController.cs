using ArchitectureClean.Infra.IoC.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureClean.MVC.Controllers
{
    public class EstagiarioController : Controller
    {
        private readonly AppDbContext _context;

        public EstagiarioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var estagiarios = _context.Estagiarios.ToList();
            return View(estagiarios);
        }
    }
}