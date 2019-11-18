using System;
using GerenciadorDeTarefas.Dominio.Entidades;

namespace GerenciadorDeTarefas.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorID(int Id);
        void Salvar(Usuario NovoUsuario);
        void MudarPermissao(Usuario Usuario);
    }
}