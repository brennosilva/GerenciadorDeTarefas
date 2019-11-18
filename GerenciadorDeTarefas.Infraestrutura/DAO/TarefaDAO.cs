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

        public void Deletar(Tarefa IdTarefa)
        {
            throw new System.NotImplementedException();
        }

        public IList<Tarefa> Listar()
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(Tarefa NovaTarefa)
        {
            throw new System.NotImplementedException();
        }

        public void Ticar(Tarefa IdTarefa)
        {
            throw new System.NotImplementedException();
        }
    }
}