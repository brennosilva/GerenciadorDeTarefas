using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;
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

        public void Logar(Usuario Usuario)
        {
            throw new System.NotImplementedException();
        }

        public void MudarPermissao(int IdUsuario, Permissao NovaPermissao)
        {
            var usuario = session.Get<Usuario>(IdUsuario);
            usuario.Permissao = NovaPermissao;
            session.SaveOrUpdate(usuario);
        }

        public void Salvar(Usuario NovoUsuario)
        {
            session.Transaction.Begin();
            session.SaveOrUpdate(NovoUsuario);
            session.Transaction.Commit();

        }
    }
}