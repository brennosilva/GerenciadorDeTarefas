using System.Collections.Generic;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Repositorios;
using NHibernate;

namespace GerenciadorDeTarefas.Infraestrutura.DAO
{
    public class TarefaDAO : ITarefaRepositorio
    {
        protected ISession session;

        public TarefaDAO(ISession session)
        {
            this.session = session;
        }

        public void Deletar(int IdTarefa)
        {
            var tarefa = session.Get<Tarefa>(IdTarefa);
            session.Transaction.Begin();
            session.Delete(tarefa);
            session.Transaction.Commit();
        }

        public void Editar(Tarefa NovaTarefa)
        {
            var tarefa = session.Get<Tarefa>(NovaTarefa.Id);
            tarefa.Nome = NovaTarefa.Nome;
            session.Transaction.Begin();
            session.SaveOrUpdate(tarefa);
            session.Transaction.Commit();
        }

        public IList<Tarefa> ListarTarefasUsuario(int idUsuario)
        {
            return session.QueryOver<Tarefa>().Where(x => x.Usuario.Id == idUsuario).List();
        }

        public void Salvar(Tarefa NovaTarefa)
        {
            session.Transaction.Begin();
            NovaTarefa.Status = Dominio.Enums.StatusTarefa.PENDENTE;
            session.SaveOrUpdate(NovaTarefa);
            session.Transaction.Commit();
        }

        public void Ticar(int IdTarefa)
        {
            var tarefa = session.Get<Tarefa>(IdTarefa);
            session.Transaction.Begin();
            tarefa.Status = Dominio.Enums.StatusTarefa.CONCLUIDO;
            session.SaveOrUpdate(tarefa);
            session.Transaction.Commit();
        }
    }
}