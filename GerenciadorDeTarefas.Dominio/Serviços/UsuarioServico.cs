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
    }
}