using System;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorID(int Id);
        Usuario BuscarPorUsuario(string Nome);
        void Salvar(Usuario NovoUsuario);
        void MudarPermissao(int IdUsuario, Permissao NovaPermissao);
    }
}