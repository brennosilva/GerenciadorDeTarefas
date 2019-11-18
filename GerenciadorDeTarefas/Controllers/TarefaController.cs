using GerenciadorDeTarefas.Dominio.Repositorios;
using GerenciadorDeTarefas.Dominio.Serviços;
using GerenciadorDeTarefas.Infraestrutura.DAO;
using GerenciadorDeTarefas.Infraestrutura.NHibernate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GerenciadorDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        IConfiguration configuration;
        public TarefaController(IConfiguration configuration) => this.configuration = configuration;


        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            try
            {
                ITarefaRepositorio tarefaRepositorio = new TarefaDAO(NhibernateHelper.OpenSession(configuration));
                TarefaServico tarefaServico = new TarefaServico(tarefaRepositorio);
                var tarefas = tarefaServico.ListarTarefas();
                return new JsonResult(tarefas);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpPost("NovaTarefa")]
        public IActionResult Salvar()
        {
            try
            {
                ITarefaRepositorio tarefaRepositorio = new TarefaDAO(NhibernateHelper.OpenSession(configuration));
                TarefaServico tarefaServico = new TarefaServico(tarefaRepositorio);
                // tarefaServico.Salvar();
                return Ok();
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpGet("Deletar")]
        public IActionResult Deletar(int id)
        {
            try
            {
                ITarefaRepositorio tarefaRepositorio = new TarefaDAO(NhibernateHelper.OpenSession(configuration));
                TarefaServico tarefaServico = new TarefaServico(tarefaRepositorio);
                tarefaServico.Deletar(id);
                return Ok();
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpGet("Ticar")]
        public IActionResult Ticar(int id)
        {
            try
            {
                ITarefaRepositorio tarefaRepositorio = new TarefaDAO(NhibernateHelper.OpenSession(configuration));
                TarefaServico tarefaServico = new TarefaServico(tarefaRepositorio);
                tarefaServico.Ticar(id);
                return Ok();
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }
    }
}