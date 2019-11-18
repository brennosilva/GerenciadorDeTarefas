using System;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorID(int Id);
        void Salvar(Usuario NovoUsuario);
        void MudarPermissao(int IdUsuario, Permissao NovaPermissao);
    }
}