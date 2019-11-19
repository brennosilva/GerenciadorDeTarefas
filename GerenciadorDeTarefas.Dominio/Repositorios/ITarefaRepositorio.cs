using System;
using System.Collections.Generic;
using GerenciadorDeTarefas.Dominio.Entidades;

namespace GerenciadorDeTarefas.Dominio.Repositorios
{
    public interface ITarefaRepositorio
    {
        void Salvar(Tarefa NovaTarefa);
        void Deletar(int IdTarefa);
        void Ticar(int IdTarefa);
        IList<Tarefa> ListarTarefasUsuario(int idUsuario);
    }
}