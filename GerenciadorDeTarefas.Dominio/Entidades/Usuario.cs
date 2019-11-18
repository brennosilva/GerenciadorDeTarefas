using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Dominio.Entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; } 
        public virtual string Nome { get; set; } 
        public virtual string Email { get; set; } 
        public virtual Permissao Permissao { get; set; } 
        public virtual string Senha { get; set; }         
    }
}