using ArchitectureClean.Application.DTOs;
using ArchitectureClean.Application.UseCases;
using Microsoft.AspNetCore.Mvc;


namespace ArchitectureClean.MVC.Controllers
{
    public class EstagiarioController : Controller
    {

        private readonly CadastrarEstagiarioUseCase _cadastrarEstagiarioUseCase;
        private readonly BuscarEstagiarioPorIdUseCase _buscarEstagiarioPorIdUseCase;
        private readonly AtualizarEstagiarioUseCase _atualizarEstagiariosUseCase;
        private readonly DeletarEstagiarioUseCase _deletarEstagiarioUseCase;


        public EstagiarioController(CadastrarEstagiarioUseCase cadastrarEstagiario, BuscarEstagiarioPorIdUseCase buscarEstagiarioPorIdUseCase, AtualizarEstagiarioUseCase atualizarEstagiariosUseCase, DeletarEstagiarioUseCase deletarEstagiarioUseCase)
        {
            _cadastrarEstagiarioUseCase = cadastrarEstagiario;
            _buscarEstagiarioPorIdUseCase = buscarEstagiarioPorIdUseCase;
            _atualizarEstagiariosUseCase = atualizarEstagiariosUseCase;
            _deletarEstagiarioUseCase = deletarEstagiarioUseCase;
        }


        [HttpGet]
        public async Task<IActionResult> BuscarEstagiarioPorId(Guid id)
        {
            try
            {
                var estagiario = await _buscarEstagiarioPorIdUseCase.ExecuteAsync(id);
                return View(estagiario);
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
        }


        [HttpDelete]
        public async Task<IActionResult> DeletarEstagiario(Guid id)
        {
            try
            {
                await _deletarEstagiarioUseCase.ExecuteAsync(id);
                return Ok("Estagiário deletado com sucesso.");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
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