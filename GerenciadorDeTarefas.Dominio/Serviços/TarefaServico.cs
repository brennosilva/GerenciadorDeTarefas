using System.Collections.Generic;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Repositorios;

namespace GerenciadorDeTarefas.Dominio.Serviços
{
    public class TarefaServico
    {
        ITarefaRepositorio repositorio;
        public TarefaServico(ITarefaRepositorio repositorio) => this.repositorio = repositorio;

        public void Salvar(Tarefa NovaTarefa)
        {
            repositorio.Salvar(NovaTarefa);
        }

         public void Editar(Tarefa NovaTarefa)
        {
            repositorio.Editar(NovaTarefa);
        }

        public void Deletar(int IdTarefa)
        {
            repositorio.Deletar(IdTarefa);
        }

        public void Ticar(int IdTarefa)
        {
            repositorio.Ticar(IdTarefa);
        }

        public void RemoveTicar(int IdTarefa)
        {
            repositorio.RemoveTicar(IdTarefa);
        }

        public IList<Tarefa> ListarTarefas(int idUsuario)
        {
            return repositorio.ListarTarefasUsuario(idUsuario);
        }


    }
}