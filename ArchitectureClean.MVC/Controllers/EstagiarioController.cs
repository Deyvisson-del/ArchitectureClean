using ArchitectureClean.Application.DTOs;
using ArchitectureClean.Application.UseCases;
using Microsoft.AspNetCore.Mvc;


namespace ArchitectureClean.MVC.Controllers
{
    public class EstagiarioController : Controller
    {

        private readonly CadastrarEstagiarioUseCase _cadastrarEstagiarioUseCase;

        public EstagiarioController(CadastrarEstagiarioUseCase cadastrarEstagiario)
        {
            _cadastrarEstagiarioUseCase = cadastrarEstagiario;
        }


        [HttpPost]
        public async Task<IActionResult> CadastrarEstagiario([FromBody] EstagiarioDTO estagiarioDTO)
        {
            try
            {
                await _cadastrarEstagiarioUseCase.ExecuteAsync(estagiarioDTO);
                return Ok("Estagiário cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View(estagiarioDTO);
            }
        }
    }
}