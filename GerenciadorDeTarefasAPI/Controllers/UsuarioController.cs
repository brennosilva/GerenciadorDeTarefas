using GerenciadorDeTarefas.Dominio;
using GerenciadorDeTarefas.Dominio.Entidades;
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
                return new JsonResult(dto);
            }
            catch (DominioException e)
            {
                return new JsonResult(e.Message);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpPost("NovoUsuario")]
        public IActionResult NovoUsuario([FromForm]CadastrarUsuarioDTO novoUsuario)
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
                UsuarioServico usuarioServico = new UsuarioServico(usuarioRepositorio);
                var entidade = CadastrarUsuarioDTO.ParseToEntidade(novoUsuario);
                usuarioServico.Salvar(entidade);
                return Ok();
            }
            catch (DominioException e)
            {
                return new JsonResult(e.Message);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpPost("Logar")]
        public IActionResult Logar([FromForm]LoginDTO login)
        {
            try
            {
                IUsuarioRepositorio usuarioRepositorio = new UsuarioDAO(NhibernateHelper.OpenSession(configuration));
                UsuarioServico usuarioServico = new UsuarioServico(usuarioRepositorio);                
                var resultado = usuarioServico.Logar(new Usuario(){Nome = login.Usuario, Senha = login.Senha});                
                var user = new LoginDTO(){Permissao = (int)resultado.Permissao , IdUsuario = resultado.Id};   
                             
                return new JsonResult(user);
                    
            }
            catch (DominioException e)
            {
                HttpContext.Response.StatusCode = 401;
                return new JsonResult(e.Message);
            }
            catch (System.Exception)
            {
                HttpContext.Response.StatusCode = 401;
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }
    }
}