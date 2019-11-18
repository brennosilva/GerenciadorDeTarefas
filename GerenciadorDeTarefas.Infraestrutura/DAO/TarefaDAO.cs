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
            session.Delete(tarefa);
        }

        public IList<Tarefa> Listar()
        {
            return session.QueryOver<Tarefa>().List();
        }

        public void Salvar(Tarefa NovaTarefa)
        {
            session.SaveOrUpdate(NovaTarefa);
        }

        public void Ticar(int IdTarefa)
        {
            var tarefa = session.Get<Tarefa>(IdTarefa);
            tarefa.Status = Dominio.Enums.StatusTarefa.CONCLUIDO;
            session.SaveOrUpdate(tarefa);
        }
    }
}