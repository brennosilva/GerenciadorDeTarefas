using System;
using System.Collections.Generic;
using GerenciadorDeTarefas.Dominio.Entidades;

namespace GerenciadorDeTarefas.Dominio.Repositorios
{
    public interface ITarefaRepositorio
    {
         void Salvar(Tarefa NovaTarefa);     
         void Deletar(Tarefa IdTarefa);
         void Ticar(Tarefa IdTarefa);
         IList<Tarefa> Listar();
    }
}