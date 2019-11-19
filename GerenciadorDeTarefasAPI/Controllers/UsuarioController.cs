using GerenciadorDeTarefas.Dominio.Repositorios;
using GerenciadorDeTarefas.Dominio.Serviços;
using GerenciadorDeTarefas.Infraestrutura.DAO;
using GerenciadorDeTarefas.Infraestrutura.NHibernate;
using GerenciadorDeTarefasAPI.DTO;
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
        public IActionResult BuscarUsuario(int id)
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
                UsuarioServico usuarioServico = new UsuarioServico(usuarioRepositorio);
                var usuario = usuarioServico.BuscarUsuarioPorId(id);
                var dto = CadastrarUsuarioDTO.ParseToDTO(usuario);
                // mudar para dto
                return new JsonResult(dto);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpPost("NovoUsuario")]
        public IActionResult NovoUsuario(CadastrarUsuarioDTO novoUsuario)
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
                UsuarioServico usuarioServico = new UsuarioServico(usuarioRepositorio);
                var entidade = CadastrarUsuarioDTO.ParseToEntidade(novoUsuario);
                usuarioServico.Salvar(entidade);
                return Ok();
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }
    }
}