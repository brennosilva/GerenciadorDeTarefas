using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;
using GerenciadorDeTarefas.Dominio.Repositorios;

namespace GerenciadorDeTarefas.Dominio.Serviços
{
    public class UsuarioServico
    {
        IUsuarioRepositorio repositorio;
        public UsuarioServico(IUsuarioRepositorio repositorio) => this.repositorio = repositorio;

        public Usuario BuscarUsuarioPorId(int id)
        {
            var usuario = repositorio.BuscarPorID(id);
            if(usuario == null) throw new DominioException("Usuário não encontrado.");
            return usuario;
        }

        public void Salvar(Usuario usuario)
        {
            repositorio.Salvar(usuario);           
        }

        public void MudarPermissao(int IdUsuario, Permissao NovaPermissao)
        {
            repositorio.MudarPermissao(IdUsuario,NovaPermissao);           
        }

        public bool Logar(Usuario usuarioLogin)
        {
            var usuario = repositorio.BuscarPorUsuario(usuarioLogin.Nome);
            if(usuario == null) throw new DominioException("Usuário ou senha incorreto!");
            if(usuario.Senha != usuarioLogin.Senha) throw new DominioException("Usuário ou senha incorreto!");
            return true;
        }
    }
}