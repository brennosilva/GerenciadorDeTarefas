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

        public Usuario BuscarPorID(int Id)
        {
            return session.Get<Usuario>(Id);
        }

        public void MudarPermissao(Usuario Usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(Usuario NovoUsuario)
        {
            session.SaveOrUpdate(NovoUsuario);
        }
    }
}