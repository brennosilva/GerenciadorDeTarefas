using GerenciadorDeTarefas.Dominio.Repositorios;
using GerenciadorDeTarefas.Infraestrutura.DAO;
using GerenciadorDeTarefas.Infraestrutura.NHibernate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GerenciadorDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IConfiguration configuration;
        public UsuarioController(IConfiguration configuration) => this.configuration = configuration;

        [HttpGet("BuscarUsuario")]
        public JsonResult BuscarUsuario()
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
            return null;
        }

        [HttpPost("NovoUsuario")]
        public JsonResult NovoUsuario()
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
            return null;
        }

    }
}