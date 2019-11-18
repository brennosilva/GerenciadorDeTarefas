using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Repositorios;
using NHibernate;

namespace GerenciadorDeTarefas.Infraestrutura.DAO
{
    public class UsuarioDAO : IUsuarioRepositorio
    {
        protected ISession session;

        public UsuarioDAO(ISession session)
        {
            this.session = session;
        }

        public Usuario BuscarPorID(string Id)
        {
            throw new System.NotImplementedException();
        }

        public void MudarPermissao(Usuario Usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(Usuario NovoUsuario)
        {
            throw new System.NotImplementedException();
        }
    }
}